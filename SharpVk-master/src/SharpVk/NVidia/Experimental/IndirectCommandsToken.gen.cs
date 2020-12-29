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

using System.Runtime.InteropServices;

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    ///     Structure specifying parameters for the reservation of command buffer
    ///     space.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct IndirectCommandsToken
    {
        /// <summary>
        ///     Specifies the token command type.
        /// </summary>
        public IndirectCommandsTokenType TokenType
        {
            get;
            set;
        }

        /// <summary>
        ///     Specifies the Buffer storing the functional arguments for each
        ///     squence. These argumetns can be written by the device.
        /// </summary>
        public Buffer Buffer
        {
            get;
            set;
        }

        /// <summary>
        ///     offset specified an offset into buffer where the arguments start.
        /// </summary>
        public ulong Offset
        {
            get;
            set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(Interop.NVidia.Experimental.IndirectCommandsToken* pointer)
        {
            pointer->TokenType = TokenType;
            pointer->Buffer = Buffer?.handle ?? default(Interop.Buffer);
            pointer->Offset = Offset;
        }

        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe IndirectCommandsToken MarshalFrom(Interop.NVidia.Experimental.IndirectCommandsToken* pointer)
        {
            var result = default(IndirectCommandsToken);
            result.TokenType = pointer->TokenType;
            result.Buffer = new(default, pointer->Buffer);
            result.Offset = pointer->Offset;
            return result;
        }
    }
}