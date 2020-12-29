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

using System;

namespace SharpVk
{
    /// <summary>
    ///     The base type for exceptions thrown by the SharpVK library.
    /// </summary>
    public abstract class SharpVkException
        : Exception
    {
        /// <summary>
        ///     Creates a new instance of the
        ///     <see
        ///         cref="SharpVk.SharpVkException" />
        ///     class .
        /// </summary>
        /// <param name="message">
        ///     The message that describes the error.
        /// </param>
        protected SharpVkException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public abstract Result ResultCode
        {
            get;
        }

        /// <summary>
        ///     Returns a value indicating whether the given Vulkan result code
        ///     represents an error.
        /// </summary>
        public static bool IsError(Result resultCode)
        {
            return (int)resultCode < 0;
        }

        /// <summary>
        ///     Creates and returns a new, specifically-typed exception that
        ///     represents the given result code.
        /// </summary>
        public static SharpVkException Create(Result resultCode)
        {
            if (!IsError(resultCode)) return null;
            switch (resultCode)
            {
                case Result.ErrorOutOfHostMemory:
                    return new OutOfHostMemoryException();
                case Result.ErrorOutOfDeviceMemory:
                    return new OutOfDeviceMemoryException();
                case Result.ErrorInitializationFailed:
                    return new InitializationFailedException();
                case Result.ErrorDeviceLost:
                    return new DeviceLostException();
                case Result.ErrorMemoryMapFailed:
                    return new MemoryMapFailedException();
                case Result.ErrorLayerNotPresent:
                    return new LayerNotPresentException();
                case Result.ErrorExtensionNotPresent:
                    return new ExtensionNotPresentException();
                case Result.ErrorFeatureNotPresent:
                    return new FeatureNotPresentException();
                case Result.ErrorIncompatibleDriver:
                    return new IncompatibleDriverException();
                case Result.ErrorTooManyObjects:
                    return new TooManyObjectsException();
                case Result.ErrorFormatNotSupported:
                    return new FormatNotSupportedException();
                case Result.ErrorFragmentedPool:
                    return new FragmentedPoolException();
                case Result.ErrorUnknown:
                    return new UnknownException();
                case Result.ErrorOutOfPoolMemoryVersion:
                    return new OutOfPoolMemoryVersionException();
                case Result.ErrorInvalidExternalHandleVersion:
                    return new InvalidExternalHandleVersionException();
                case Result.ErrorFragmentationVersion:
                    return new FragmentationVersionException();
                case Result.ErrorInvalidOpaqueCaptureAddressVersion:
                    return new InvalidOpaqueCaptureAddressVersionException();
                case Result.ErrorSurfaceLost:
                    return new SurfaceLostException();
                case Result.ErrorNativeWindowInUse:
                    return new NativeWindowInUseException();
                case Result.ErrorOutOfDate:
                    return new OutOfDateException();
                case Result.ErrorIncompatibleDisplay:
                    return new IncompatibleDisplayException();
                case Result.ErrorValidationFailed:
                    return new ValidationFailedException();
                case Result.ErrorInvalidShader:
                    return new InvalidShaderException();
                case Result.ErrorInvalidDrmFormatModifierPlaneLayout:
                    return new InvalidDrmFormatModifierPlaneLayoutException();
                case Result.ErrorNotPermitted:
                    return new NotPermittedException();
                case Result.ErrorFullScreenExclusiveModeLost:
                    return new FullScreenExclusiveModeLostException();
            }
            return new UnknownSharpVkException(resultCode);
        }
    }

    /// <summary>
    ///     An exception representing a result code not recognised by the SharpVk
    ///     library.
    /// </summary>
    public class UnknownSharpVkException
        : SharpVkException
    {
        internal UnknownSharpVkException(Result resultCode)
            : base($"An unknown exception as been thrown by the Vulkan API: {resultCode}")
        {
            this.ResultCode = resultCode;
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode { get; }
    }

    /// <summary>
    /// </summary>
    public class OutOfHostMemoryException
        : SharpVkException
    {
        internal OutOfHostMemoryException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorOutOfHostMemory;
    }

    /// <summary>
    /// </summary>
    public class OutOfDeviceMemoryException
        : SharpVkException
    {
        internal OutOfDeviceMemoryException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorOutOfDeviceMemory;
    }

    /// <summary>
    /// </summary>
    public class InitializationFailedException
        : SharpVkException
    {
        internal InitializationFailedException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorInitializationFailed;
    }

    /// <summary>
    /// </summary>
    public class DeviceLostException
        : SharpVkException
    {
        internal DeviceLostException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorDeviceLost;
    }

    /// <summary>
    /// </summary>
    public class MemoryMapFailedException
        : SharpVkException
    {
        internal MemoryMapFailedException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorMemoryMapFailed;
    }

    /// <summary>
    /// </summary>
    public class LayerNotPresentException
        : SharpVkException
    {
        internal LayerNotPresentException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorLayerNotPresent;
    }

    /// <summary>
    /// </summary>
    public class ExtensionNotPresentException
        : SharpVkException
    {
        internal ExtensionNotPresentException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorExtensionNotPresent;
    }

    /// <summary>
    /// </summary>
    public class FeatureNotPresentException
        : SharpVkException
    {
        internal FeatureNotPresentException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorFeatureNotPresent;
    }

    /// <summary>
    /// </summary>
    public class IncompatibleDriverException
        : SharpVkException
    {
        internal IncompatibleDriverException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorIncompatibleDriver;
    }

    /// <summary>
    /// </summary>
    public class TooManyObjectsException
        : SharpVkException
    {
        internal TooManyObjectsException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorTooManyObjects;
    }

    /// <summary>
    /// </summary>
    public class FormatNotSupportedException
        : SharpVkException
    {
        internal FormatNotSupportedException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorFormatNotSupported;
    }

    /// <summary>
    /// </summary>
    public class FragmentedPoolException
        : SharpVkException
    {
        internal FragmentedPoolException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorFragmentedPool;
    }

    /// <summary>
    /// </summary>
    public class UnknownException
        : SharpVkException
    {
        internal UnknownException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorUnknown;
    }

    /// <summary>
    /// </summary>
    public class OutOfPoolMemoryVersionException
        : SharpVkException
    {
        internal OutOfPoolMemoryVersionException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorOutOfPoolMemoryVersion;
    }

    /// <summary>
    /// </summary>
    public class InvalidExternalHandleVersionException
        : SharpVkException
    {
        internal InvalidExternalHandleVersionException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorInvalidExternalHandleVersion;
    }

    /// <summary>
    /// </summary>
    public class FragmentationVersionException
        : SharpVkException
    {
        internal FragmentationVersionException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorFragmentationVersion;
    }

    /// <summary>
    /// </summary>
    public class InvalidOpaqueCaptureAddressVersionException
        : SharpVkException
    {
        internal InvalidOpaqueCaptureAddressVersionException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorInvalidOpaqueCaptureAddressVersion;
    }

    /// <summary>
    /// </summary>
    public class SurfaceLostException
        : SharpVkException
    {
        internal SurfaceLostException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorSurfaceLost;
    }

    /// <summary>
    /// </summary>
    public class NativeWindowInUseException
        : SharpVkException
    {
        internal NativeWindowInUseException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorNativeWindowInUse;
    }

    /// <summary>
    /// </summary>
    public class OutOfDateException
        : SharpVkException
    {
        internal OutOfDateException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorOutOfDate;
    }

    /// <summary>
    /// </summary>
    public class IncompatibleDisplayException
        : SharpVkException
    {
        internal IncompatibleDisplayException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorIncompatibleDisplay;
    }

    /// <summary>
    /// </summary>
    public class ValidationFailedException
        : SharpVkException
    {
        internal ValidationFailedException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorValidationFailed;
    }

    /// <summary>
    /// </summary>
    public class InvalidShaderException
        : SharpVkException
    {
        internal InvalidShaderException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorInvalidShader;
    }

    /// <summary>
    /// </summary>
    public class InvalidDrmFormatModifierPlaneLayoutException
        : SharpVkException
    {
        internal InvalidDrmFormatModifierPlaneLayoutException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorInvalidDrmFormatModifierPlaneLayout;
    }

    /// <summary>
    /// </summary>
    public class NotPermittedException
        : SharpVkException
    {
        internal NotPermittedException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorNotPermitted;
    }

    /// <summary>
    /// </summary>
    public class FullScreenExclusiveModeLostException
        : SharpVkException
    {
        internal FullScreenExclusiveModeLostException()
            : base("")
        {
        }

        /// <summary>
        ///     The Vulkan result code represented by this exception.
        /// </summary>
        public override Result ResultCode => Result.ErrorFullScreenExclusiveModeLost;
    }
}