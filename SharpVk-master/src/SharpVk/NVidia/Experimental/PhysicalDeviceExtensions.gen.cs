// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2020
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

using SharpVk.Interop;

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    /// </summary>
    public static class PhysicalDeviceExtensions
    {
        /// <summary>
        ///     Returns device-generated commands related properties of a physical
        ///     device.
        /// </summary>
        /// <param name="extendedHandle">
        ///     The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="features">
        /// </param>
        public static unsafe DeviceGeneratedCommandsLimits GetGeneratedCommandsProperties(this PhysicalDevice extendedHandle, DeviceGeneratedCommandsFeatures features)
        {
            try
            {
                var result = default(DeviceGeneratedCommandsLimits);
                var commandCache = default(CommandCache);
                var marshalledFeatures = default(Interop.NVidia.Experimental.DeviceGeneratedCommandsFeatures*);
                var marshalledLimits = default(Interop.NVidia.Experimental.DeviceGeneratedCommandsLimits);
                commandCache = extendedHandle.CommandCache;
                marshalledFeatures = (Interop.NVidia.Experimental.DeviceGeneratedCommandsFeatures*)HeapUtil.Allocate<Interop.NVidia.Experimental.DeviceGeneratedCommandsFeatures>();
                features.MarshalTo(marshalledFeatures);
                var commandDelegate = commandCache.Cache.VkGetPhysicalDeviceGeneratedCommandsPropertiesNvx;
                commandDelegate(extendedHandle.Handle, marshalledFeatures, &marshalledLimits);
                result = DeviceGeneratedCommandsLimits.MarshalFrom(&marshalledLimits);
                return result;
            }
            finally
            {
                HeapUtil.FreeAll();
            }
        }
    }
}
