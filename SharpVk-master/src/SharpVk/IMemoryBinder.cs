using System;

namespace SharpVk
{
    /// <summary>
    ///     Represents a Vulkan object that can be bound to device memory.
    /// </summary>
    public interface IMemoryBinder
        : IDisposable
    {
        /// <summary>
        ///     Bind device memory to a Vulkan object.
        /// </summary>
        void BindMemory(DeviceMemory memory, ulong memoryOffset);

        /// <summary>
        ///     Returns the memory requirements for specified Vulkan object.
        /// </summary>
        MemoryRequirements GetMemoryRequirements();
    }
}