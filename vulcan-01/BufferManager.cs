using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharpVk;
using Buffer = SharpVk.Buffer;

namespace vulcan_01
{
    internal record BufferPack(Buffer VertexBuffer, DeviceMemory VertexBufferMemory, uint VerticesLength, Buffer IndexBuffer, DeviceMemory IndexBufferMemory, uint IndicesLength);

    internal class BufferManager : IDisposable
    {
        private Device device;
        private PhysicalDevice physicalDevice;
        private Queue transferQueue;
        private CommandPool transientCommandPool;

        public object BufferLock { get; } = new();
        public List<BufferPack> Buffers { get; } = new();

        public BufferManager(Device device, PhysicalDevice physicalDevice, Queue transferQueue, CommandPool transientCommandPool)
        {
            this.device = device;
            this.physicalDevice = physicalDevice;
            this.transferQueue = transferQueue;
            this.transientCommandPool = transientCommandPool;
        }

        public void AddBuffer(Vertex[] vertices, ushort[] indices)
        {
            lock (BufferLock)
            {
                var (vertexBuffer, vertexBufferMemory) = CreateVertexBuffers(vertices);
                var (indexBuffers, indexBufferMemory) = CreateIndexBuffer(indices);
                Buffers.Add(new(vertexBuffer, vertexBufferMemory, (uint)vertices.Length, indexBuffers, indexBufferMemory, (uint)indices.Length));
            }
        }

        public (Buffer vertexBuffer, DeviceMemory vertexBufferMemory) CreateVertexBuffers(Vertex[] val)
        {
            var bufferSize = CreateCopyBuffer(ref val, out var stagingBuffer, out var stagingBufferMemory);

            stagingBufferMemory.Unmap();

            CreateBuffer(bufferSize, BufferUsageFlags.TransferDestination | BufferUsageFlags.VertexBuffer, MemoryPropertyFlags.DeviceLocal, out var vertexBuffer, out var vertexBufferMemory);

            CopyBuffer(stagingBuffer, vertexBuffer, bufferSize);

            stagingBuffer.Dispose();
            stagingBufferMemory.Free();

            return (vertexBuffer, vertexBufferMemory);
        }

        public (Buffer indexBuffers, DeviceMemory indexBufferMemory) CreateIndexBuffer(ushort[] val)
        {
            var bufferSize = CreateCopyBuffer(ref val, out var stagingBuffer, out var stagingBufferMemory);

            CreateBuffer(bufferSize, BufferUsageFlags.TransferDestination | BufferUsageFlags.IndexBuffer, MemoryPropertyFlags.DeviceLocal, out var indexBuffers, out var indexBufferMemory);

            CopyBuffer(stagingBuffer, indexBuffers, bufferSize);

            stagingBuffer.Dispose();
            stagingBufferMemory.Free();

            return (indexBuffers, indexBufferMemory);
        }

        public uint CreateCopyBuffer<T>(ref T[] value, out Buffer stagingBuffer, out DeviceMemory stagingBufferMemory)
        {
            var size = Unsafe.SizeOf<T>();
            var bufferSize = (uint)(size * value.Length);

            CreateBuffer(bufferSize, BufferUsageFlags.TransferSource, MemoryPropertyFlags.HostVisible | MemoryPropertyFlags.HostCoherent, out stagingBuffer, out stagingBufferMemory);

            var memoryBuffer = stagingBufferMemory.Map(0, bufferSize, MemoryMapFlags.None);

            for (var index = 0; index < value.Length; index++)
            {
                Marshal.StructureToPtr(value[index], memoryBuffer + (size * index), false);
            }

            stagingBufferMemory.Unmap();
            return bufferSize;
        }

        public void CreateBuffer(ulong size, BufferUsageFlags usage, MemoryPropertyFlags properties, out Buffer buffer, out DeviceMemory bufferMemory)
        {
            buffer = device.CreateBuffer(size, usage, SharingMode.Exclusive, null);

            var memRequirements = buffer.GetMemoryRequirements();

            bufferMemory = device.AllocateMemory(memRequirements.Size, FindMemoryType(memRequirements.MemoryTypeBits, properties));

            buffer.BindMemory(bufferMemory, 0);
        }

        public void CopyBuffer(Buffer sourceBuffer, Buffer destinationBuffer, ulong size)
        {
            var transferBuffers = device.AllocateCommandBuffers(transientCommandPool, CommandBufferLevel.Primary, 1);

            transferBuffers[0].Begin(CommandBufferUsageFlags.OneTimeSubmit);

            transferBuffers[0].CopyBuffer(sourceBuffer, destinationBuffer, new BufferCopy
            {
                Size = size
            });

            transferBuffers[0].End();

            transferQueue.Submit(new SubmitInfo
            {
                CommandBuffers = transferBuffers
            }, null);
            transferQueue.WaitIdle();

            transientCommandPool.FreeCommandBuffers(transferBuffers);
        }

        private uint FindMemoryType(uint typeFilter, MemoryPropertyFlags flags)
        {
            var memoryProperties = physicalDevice.GetMemoryProperties();

            for (var i = 0; i < memoryProperties.MemoryTypes.Length; i++)
            {
                if ((typeFilter & (1u << i)) > 0
                    && memoryProperties.MemoryTypes[i].PropertyFlags.HasFlag(flags))
                {
                    return (uint)i;
                }
            }

            throw new("No compatible memory type.");
        }

        private void ReleaseUnmanagedResources()
        {
            device = null;
            physicalDevice = null;
            transferQueue = null;
            transientCommandPool = null;
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        ~BufferManager()
        {
            ReleaseUnmanagedResources();
        }

        public void BindAllAndDraw(CommandBuffer commandBuffer)
        {
            lock (BufferLock)
            {
                foreach (var (vertexBuffer, _, _, indexBuffer, _, indicesLength) in Buffers)
                {
                    commandBuffer.BindVertexBuffers(0, vertexBuffer, 0);

                    commandBuffer.BindIndexBuffer(indexBuffer, 0, IndexType.Uint16);
                    commandBuffer.DrawIndexed(indicesLength, 1, 0, 0, 0);
                }
            }
        }
    }
}
