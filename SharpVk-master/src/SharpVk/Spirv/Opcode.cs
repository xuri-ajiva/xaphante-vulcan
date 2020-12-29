// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2017
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

namespace SharpVk.Spirv
{
    /// <summary>
    /// </summary>
    public partial struct OpCode
    {
        /// <summary>
        /// </summary>
        public static readonly OpCode OpNop = new()
        {
            Op = Op.OpNop
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpUndef = new()
        {
            Op = Op.OpUndef,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSourceContinued = new()
        {
            Op = Op.OpSourceContinued,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'Continued Source'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSource = new()
        {
            Op = Op.OpSource,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.SourceLanguage,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Version'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Optional,
                    Name = "'File'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.Optional,
                    Name = "'Source'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSourceExtension = new()
        {
            Op = Op.OpSourceExtension,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'Extension'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpName = new()
        {
            Op = Op.OpName,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Target'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'Name'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpMemberName = new()
        {
            Op = Op.OpMemberName,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Type'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Member'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'Name'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpString = new()
        {
            Op = Op.OpString,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'String'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpLine = new()
        {
            Op = Op.OpLine,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'File'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Line'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Column'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpExtension = new()
        {
            Op = Op.OpExtension,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'Name'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpExtInstImport = new()
        {
            Op = Op.OpExtInstImport,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'Name'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpExtInst = new()
        {
            Op = Op.OpExtInst,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Set'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralExtInstInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Instruction'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Operand 1', +'Operand 2', +..."
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpMemoryModel = new()
        {
            Op = Op.OpMemoryModel,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.AddressingModel,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.MemoryModel,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpEntryPoint = new()
        {
            Op = Op.OpEntryPoint,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.ExecutionModel,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Entry Point'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'Name'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Interface'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpExecutionMode = new()
        {
            Op = Op.OpExecutionMode,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Entry Point'"
                },
                new Operand
                {
                    Kind = OperandKind.ExecutionMode,
                    Quantifier = Quantifier.None,
                    Name = "'Mode'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpCapability = new()
        {
            Op = Op.OpCapability,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.Capability,
                    Quantifier = Quantifier.None,
                    Name = "'Capability'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeVoid = new()
        {
            Op = Op.OpTypeVoid,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeBool = new()
        {
            Op = Op.OpTypeBool,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeInt = new()
        {
            Op = Op.OpTypeInt,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Width'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Signedness'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeFloat = new()
        {
            Op = Op.OpTypeFloat,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Width'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeVector = new()
        {
            Op = Op.OpTypeVector,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Component Type'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Component Count'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeMatrix = new()
        {
            Op = Op.OpTypeMatrix,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Column Type'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Column Count'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeImage = new()
        {
            Op = Op.OpTypeImage,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Type'"
                },
                new Operand
                {
                    Kind = OperandKind.Dim,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Depth'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Arrayed'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'MS'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageFormat,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.AccessQualifier,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeSampler = new()
        {
            Op = Op.OpTypeSampler,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeSampledImage = new()
        {
            Op = Op.OpTypeSampledImage,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image Type'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeArray = new()
        {
            Op = Op.OpTypeArray,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Element Type'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Length'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeRuntimeArray = new()
        {
            Op = Op.OpTypeRuntimeArray,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Element Type'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeStruct = new()
        {
            Op = Op.OpTypeStruct,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Member 0 type', +'member 1 type', +..."
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeOpaque = new()
        {
            Op = Op.OpTypeOpaque,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "The name of the opaque type."
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypePointer = new()
        {
            Op = Op.OpTypePointer,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.StorageClass,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Type'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeFunction = new()
        {
            Op = Op.OpTypeFunction,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Return Type'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Parameter 0 Type', +'Parameter 1 Type', +..."
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeEvent = new()
        {
            Op = Op.OpTypeEvent,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeDeviceEvent = new()
        {
            Op = Op.OpTypeDeviceEvent,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeReserveId = new()
        {
            Op = Op.OpTypeReserveId,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeQueue = new()
        {
            Op = Op.OpTypeQueue,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypePipe = new()
        {
            Op = Op.OpTypePipe,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.AccessQualifier,
                    Quantifier = Quantifier.None,
                    Name = "'Qualifier'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeForwardPointer = new()
        {
            Op = Op.OpTypeForwardPointer,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer Type'"
                },
                new Operand
                {
                    Kind = OperandKind.StorageClass,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpConstantTrue = new()
        {
            Op = Op.OpConstantTrue,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpConstantFalse = new()
        {
            Op = Op.OpConstantFalse,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpConstant = new()
        {
            Op = Op.OpConstant,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralContextDependentNumber,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpConstantComposite = new()
        {
            Op = Op.OpConstantComposite,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Constituents'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpConstantSampler = new()
        {
            Op = Op.OpConstantSampler,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.SamplerAddressingMode,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Param'"
                },
                new Operand
                {
                    Kind = OperandKind.SamplerFilterMode,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpConstantNull = new()
        {
            Op = Op.OpConstantNull,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSpecConstantTrue = new()
        {
            Op = Op.OpSpecConstantTrue,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSpecConstantFalse = new()
        {
            Op = Op.OpSpecConstantFalse,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSpecConstant = new()
        {
            Op = Op.OpSpecConstant,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralContextDependentNumber,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSpecConstantComposite = new()
        {
            Op = Op.OpSpecConstantComposite,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Constituents'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSpecConstantOp = new()
        {
            Op = Op.OpSpecConstantOp,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralSpecConstantOpInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Opcode'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFunction = new()
        {
            Op = Op.OpFunction,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.FunctionControl,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Function Type'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFunctionParameter = new()
        {
            Op = Op.OpFunctionParameter,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFunctionEnd = new()
        {
            Op = Op.OpFunctionEnd
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFunctionCall = new()
        {
            Op = Op.OpFunctionCall,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Function'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Argument 0', +'Argument 1', +..."
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpVariable = new()
        {
            Op = Op.OpVariable,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.StorageClass,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Optional,
                    Name = "'Initializer'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageTexelPointer = new()
        {
            Op = Op.OpImageTexelPointer,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sample'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpLoad = new()
        {
            Op = Op.OpLoad,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.MemoryAccess,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpStore = new()
        {
            Op = Op.OpStore,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Object'"
                },
                new Operand
                {
                    Kind = OperandKind.MemoryAccess,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpCopyMemory = new()
        {
            Op = Op.OpCopyMemory,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Target'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Source'"
                },
                new Operand
                {
                    Kind = OperandKind.MemoryAccess,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpCopyMemorySized = new()
        {
            Op = Op.OpCopyMemorySized,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Target'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Source'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Size'"
                },
                new Operand
                {
                    Kind = OperandKind.MemoryAccess,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAccessChain = new()
        {
            Op = Op.OpAccessChain,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Indexes'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpInBoundsAccessChain = new()
        {
            Op = Op.OpInBoundsAccessChain,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Indexes'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpPtrAccessChain = new()
        {
            Op = Op.OpPtrAccessChain,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Element'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Indexes'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpArrayLength = new()
        {
            Op = Op.OpArrayLength,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Structure'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Array member'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGenericPtrMemSemantics = new()
        {
            Op = Op.OpGenericPtrMemSemantics,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpInBoundsPtrAccessChain = new()
        {
            Op = Op.OpInBoundsPtrAccessChain,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Element'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Indexes'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpDecorate = new()
        {
            Op = Op.OpDecorate,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Target'"
                },
                new Operand
                {
                    Kind = OperandKind.Decoration,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpMemberDecorate = new()
        {
            Op = Op.OpMemberDecorate,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Structure Type'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Member'"
                },
                new Operand
                {
                    Kind = OperandKind.Decoration,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpDecorationGroup = new()
        {
            Op = Op.OpDecorationGroup,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupDecorate = new()
        {
            Op = Op.OpGroupDecorate,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Decoration Group'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Targets'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupMemberDecorate = new()
        {
            Op = Op.OpGroupMemberDecorate,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Decoration Group'"
                },
                new Operand
                {
                    Kind = OperandKind.PairIdRefLiteralInteger,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Targets'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpVectorExtractDynamic = new()
        {
            Op = Op.OpVectorExtractDynamic,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Index'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpVectorInsertDynamic = new()
        {
            Op = Op.OpVectorInsertDynamic,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Component'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Index'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpVectorShuffle = new()
        {
            Op = Op.OpVectorShuffle,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector 2'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Components'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpCompositeConstruct = new()
        {
            Op = Op.OpCompositeConstruct,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Constituents'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpCompositeExtract = new()
        {
            Op = Op.OpCompositeExtract,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Composite'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Indexes'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpCompositeInsert = new()
        {
            Op = Op.OpCompositeInsert,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Object'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Composite'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Indexes'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpCopyObject = new()
        {
            Op = Op.OpCopyObject,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTranspose = new()
        {
            Op = Op.OpTranspose,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Matrix'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSampledImage = new()
        {
            Op = Op.OpSampledImage,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampler'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSampleImplicitLod = new()
        {
            Op = Op.OpImageSampleImplicitLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSampleExplicitLod = new()
        {
            Op = Op.OpImageSampleExplicitLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSampleDrefImplicitLod = new()
        {
            Op = Op.OpImageSampleDrefImplicitLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSampleDrefExplicitLod = new()
        {
            Op = Op.OpImageSampleDrefExplicitLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSampleProjImplicitLod = new()
        {
            Op = Op.OpImageSampleProjImplicitLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSampleProjExplicitLod = new()
        {
            Op = Op.OpImageSampleProjExplicitLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSampleProjDrefImplicitLod = new()
        {
            Op = Op.OpImageSampleProjDrefImplicitLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSampleProjDrefExplicitLod = new()
        {
            Op = Op.OpImageSampleProjDrefExplicitLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageFetch = new()
        {
            Op = Op.OpImageFetch,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageGather = new()
        {
            Op = Op.OpImageGather,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Component'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageDrefGather = new()
        {
            Op = Op.OpImageDrefGather,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageRead = new()
        {
            Op = Op.OpImageRead,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageWrite = new()
        {
            Op = Op.OpImageWrite,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Texel'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImage = new()
        {
            Op = Op.OpImage,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageQueryFormat = new()
        {
            Op = Op.OpImageQueryFormat,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageQueryOrder = new()
        {
            Op = Op.OpImageQueryOrder,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageQuerySizeLod = new()
        {
            Op = Op.OpImageQuerySizeLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Level of Detail'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageQuerySize = new()
        {
            Op = Op.OpImageQuerySize,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageQueryLod = new()
        {
            Op = Op.OpImageQueryLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageQueryLevels = new()
        {
            Op = Op.OpImageQueryLevels,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageQuerySamples = new()
        {
            Op = Op.OpImageQuerySamples,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpConvertFToU = new()
        {
            Op = Op.OpConvertFToU,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Float Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpConvertFToS = new()
        {
            Op = Op.OpConvertFToS,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Float Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpConvertSToF = new()
        {
            Op = Op.OpConvertSToF,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Signed Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpConvertUToF = new()
        {
            Op = Op.OpConvertUToF,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Unsigned Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpUConvert = new()
        {
            Op = Op.OpUConvert,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Unsigned Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSConvert = new()
        {
            Op = Op.OpSConvert,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Signed Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFConvert = new()
        {
            Op = Op.OpFConvert,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Float Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpQuantizeToF16 = new()
        {
            Op = Op.OpQuantizeToF16,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpConvertPtrToU = new()
        {
            Op = Op.OpConvertPtrToU,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSatConvertSToU = new()
        {
            Op = Op.OpSatConvertSToU,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Signed Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSatConvertUToS = new()
        {
            Op = Op.OpSatConvertUToS,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Unsigned Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpConvertUToPtr = new()
        {
            Op = Op.OpConvertUToPtr,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Integer Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpPtrCastToGeneric = new()
        {
            Op = Op.OpPtrCastToGeneric,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGenericCastToPtr = new()
        {
            Op = Op.OpGenericCastToPtr,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGenericCastToPtrExplicit = new()
        {
            Op = Op.OpGenericCastToPtrExplicit,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.StorageClass,
                    Quantifier = Quantifier.None,
                    Name = "'Storage'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpBitcast = new()
        {
            Op = Op.OpBitcast,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSNegate = new()
        {
            Op = Op.OpSNegate,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFNegate = new()
        {
            Op = Op.OpFNegate,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpIAdd = new()
        {
            Op = Op.OpIAdd,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFAdd = new()
        {
            Op = Op.OpFAdd,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpISub = new()
        {
            Op = Op.OpISub,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFSub = new()
        {
            Op = Op.OpFSub,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpIMul = new()
        {
            Op = Op.OpIMul,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFMul = new()
        {
            Op = Op.OpFMul,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpUDiv = new()
        {
            Op = Op.OpUDiv,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSDiv = new()
        {
            Op = Op.OpSDiv,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFDiv = new()
        {
            Op = Op.OpFDiv,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpUMod = new()
        {
            Op = Op.OpUMod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSRem = new()
        {
            Op = Op.OpSRem,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSMod = new()
        {
            Op = Op.OpSMod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFRem = new()
        {
            Op = Op.OpFRem,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFMod = new()
        {
            Op = Op.OpFMod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpVectorTimesScalar = new()
        {
            Op = Op.OpVectorTimesScalar,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Scalar'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpMatrixTimesScalar = new()
        {
            Op = Op.OpMatrixTimesScalar,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Matrix'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Scalar'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpVectorTimesMatrix = new()
        {
            Op = Op.OpVectorTimesMatrix,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Matrix'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpMatrixTimesVector = new()
        {
            Op = Op.OpMatrixTimesVector,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Matrix'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpMatrixTimesMatrix = new()
        {
            Op = Op.OpMatrixTimesMatrix,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'LeftMatrix'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'RightMatrix'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpOuterProduct = new()
        {
            Op = Op.OpOuterProduct,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpDot = new()
        {
            Op = Op.OpDot,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpIAddCarry = new()
        {
            Op = Op.OpIAddCarry,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpISubBorrow = new()
        {
            Op = Op.OpISubBorrow,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpUMulExtended = new()
        {
            Op = Op.OpUMulExtended,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSMulExtended = new()
        {
            Op = Op.OpSMulExtended,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAny = new()
        {
            Op = Op.OpAny,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAll = new()
        {
            Op = Op.OpAll,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpIsNan = new()
        {
            Op = Op.OpIsNan,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'x'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpIsInf = new()
        {
            Op = Op.OpIsInf,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'x'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpIsFinite = new()
        {
            Op = Op.OpIsFinite,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'x'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpIsNormal = new()
        {
            Op = Op.OpIsNormal,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'x'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSignBitSet = new()
        {
            Op = Op.OpSignBitSet,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'x'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpLessOrGreater = new()
        {
            Op = Op.OpLessOrGreater,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'x'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'y'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpOrdered = new()
        {
            Op = Op.OpOrdered,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'x'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'y'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpUnordered = new()
        {
            Op = Op.OpUnordered,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'x'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'y'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpLogicalEqual = new()
        {
            Op = Op.OpLogicalEqual,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpLogicalNotEqual = new()
        {
            Op = Op.OpLogicalNotEqual,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpLogicalOr = new()
        {
            Op = Op.OpLogicalOr,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpLogicalAnd = new()
        {
            Op = Op.OpLogicalAnd,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpLogicalNot = new()
        {
            Op = Op.OpLogicalNot,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSelect = new()
        {
            Op = Op.OpSelect,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Condition'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Object 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Object 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpIEqual = new()
        {
            Op = Op.OpIEqual,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpINotEqual = new()
        {
            Op = Op.OpINotEqual,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpUGreaterThan = new()
        {
            Op = Op.OpUGreaterThan,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSGreaterThan = new()
        {
            Op = Op.OpSGreaterThan,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpUGreaterThanEqual = new()
        {
            Op = Op.OpUGreaterThanEqual,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSGreaterThanEqual = new()
        {
            Op = Op.OpSGreaterThanEqual,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpULessThan = new()
        {
            Op = Op.OpULessThan,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSLessThan = new()
        {
            Op = Op.OpSLessThan,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpULessThanEqual = new()
        {
            Op = Op.OpULessThanEqual,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSLessThanEqual = new()
        {
            Op = Op.OpSLessThanEqual,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFOrdEqual = new()
        {
            Op = Op.OpFOrdEqual,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFUnordEqual = new()
        {
            Op = Op.OpFUnordEqual,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFOrdNotEqual = new()
        {
            Op = Op.OpFOrdNotEqual,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFUnordNotEqual = new()
        {
            Op = Op.OpFUnordNotEqual,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFOrdLessThan = new()
        {
            Op = Op.OpFOrdLessThan,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFUnordLessThan = new()
        {
            Op = Op.OpFUnordLessThan,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFOrdGreaterThan = new()
        {
            Op = Op.OpFOrdGreaterThan,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFUnordGreaterThan = new()
        {
            Op = Op.OpFUnordGreaterThan,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFOrdLessThanEqual = new()
        {
            Op = Op.OpFOrdLessThanEqual,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFUnordLessThanEqual = new()
        {
            Op = Op.OpFUnordLessThanEqual,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFOrdGreaterThanEqual = new()
        {
            Op = Op.OpFOrdGreaterThanEqual,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFUnordGreaterThanEqual = new()
        {
            Op = Op.OpFUnordGreaterThanEqual,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpShiftRightLogical = new()
        {
            Op = Op.OpShiftRightLogical,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Shift'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpShiftRightArithmetic = new()
        {
            Op = Op.OpShiftRightArithmetic,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Shift'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpShiftLeftLogical = new()
        {
            Op = Op.OpShiftLeftLogical,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Shift'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpBitwiseOr = new()
        {
            Op = Op.OpBitwiseOr,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpBitwiseXor = new()
        {
            Op = Op.OpBitwiseXor,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpBitwiseAnd = new()
        {
            Op = Op.OpBitwiseAnd,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpNot = new()
        {
            Op = Op.OpNot,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpBitFieldInsert = new()
        {
            Op = Op.OpBitFieldInsert,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Insert'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Offset'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Count'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpBitFieldSExtract = new()
        {
            Op = Op.OpBitFieldSExtract,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Offset'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Count'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpBitFieldUExtract = new()
        {
            Op = Op.OpBitFieldUExtract,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Offset'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Count'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpBitReverse = new()
        {
            Op = Op.OpBitReverse,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpBitCount = new()
        {
            Op = Op.OpBitCount,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpDPdx = new()
        {
            Op = Op.OpDPdx,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpDPdy = new()
        {
            Op = Op.OpDPdy,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFwidth = new()
        {
            Op = Op.OpFwidth,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpDPdxFine = new()
        {
            Op = Op.OpDPdxFine,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpDPdyFine = new()
        {
            Op = Op.OpDPdyFine,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFwidthFine = new()
        {
            Op = Op.OpFwidthFine,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpDPdxCoarse = new()
        {
            Op = Op.OpDPdxCoarse,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpDPdyCoarse = new()
        {
            Op = Op.OpDPdyCoarse,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpFwidthCoarse = new()
        {
            Op = Op.OpFwidthCoarse,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpEmitVertex = new()
        {
            Op = Op.OpEmitVertex
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpEndPrimitive = new()
        {
            Op = Op.OpEndPrimitive
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpEmitStreamVertex = new()
        {
            Op = Op.OpEmitStreamVertex,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Stream'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpEndStreamPrimitive = new()
        {
            Op = Op.OpEndStreamPrimitive,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Stream'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpControlBarrier = new()
        {
            Op = Op.OpControlBarrier,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Memory'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpMemoryBarrier = new()
        {
            Op = Op.OpMemoryBarrier,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Memory'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicLoad = new()
        {
            Op = Op.OpAtomicLoad,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicStore = new()
        {
            Op = Op.OpAtomicStore,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicExchange = new()
        {
            Op = Op.OpAtomicExchange,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicCompareExchange = new()
        {
            Op = Op.OpAtomicCompareExchange,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Equal'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Unequal'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Comparator'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicCompareExchangeWeak = new()
        {
            Op = Op.OpAtomicCompareExchangeWeak,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Equal'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Unequal'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Comparator'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicIIncrement = new()
        {
            Op = Op.OpAtomicIIncrement,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicIDecrement = new()
        {
            Op = Op.OpAtomicIDecrement,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicIAdd = new()
        {
            Op = Op.OpAtomicIAdd,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicISub = new()
        {
            Op = Op.OpAtomicISub,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicSMin = new()
        {
            Op = Op.OpAtomicSMin,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicUMin = new()
        {
            Op = Op.OpAtomicUMin,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicSMax = new()
        {
            Op = Op.OpAtomicSMax,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicUMax = new()
        {
            Op = Op.OpAtomicUMax,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicAnd = new()
        {
            Op = Op.OpAtomicAnd,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicOr = new()
        {
            Op = Op.OpAtomicOr,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicXor = new()
        {
            Op = Op.OpAtomicXor,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpPhi = new()
        {
            Op = Op.OpPhi,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.PairIdRefIdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Variable, Parent, ...'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpLoopMerge = new()
        {
            Op = Op.OpLoopMerge,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Merge Block'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Continue Target'"
                },
                new Operand
                {
                    Kind = OperandKind.LoopControl,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSelectionMerge = new()
        {
            Op = Op.OpSelectionMerge,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Merge Block'"
                },
                new Operand
                {
                    Kind = OperandKind.SelectionControl,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpLabel = new()
        {
            Op = Op.OpLabel,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpBranch = new()
        {
            Op = Op.OpBranch,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Target Label'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpBranchConditional = new()
        {
            Op = Op.OpBranchConditional,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Condition'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'True Label'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'False Label'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Branch weights'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSwitch = new()
        {
            Op = Op.OpSwitch,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Selector'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Default'"
                },
                new Operand
                {
                    Kind = OperandKind.PairLiteralIntegerIdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Target'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpKill = new()
        {
            Op = Op.OpKill
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpReturn = new()
        {
            Op = Op.OpReturn
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpReturnValue = new()
        {
            Op = Op.OpReturnValue,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpUnreachable = new()
        {
            Op = Op.OpUnreachable
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpLifetimeStart = new()
        {
            Op = Op.OpLifetimeStart,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Size'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpLifetimeStop = new()
        {
            Op = Op.OpLifetimeStop,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Size'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupAsyncCopy = new()
        {
            Op = Op.OpGroupAsyncCopy,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Destination'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Source'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Num Elements'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Stride'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Event'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupWaitEvents = new()
        {
            Op = Op.OpGroupWaitEvents,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Num Events'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Events List'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupAll = new()
        {
            Op = Op.OpGroupAll,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Predicate'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupAny = new()
        {
            Op = Op.OpGroupAny,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Predicate'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupBroadcast = new()
        {
            Op = Op.OpGroupBroadcast,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'LocalId'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupIAdd = new()
        {
            Op = Op.OpGroupIAdd,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.GroupOperation,
                    Quantifier = Quantifier.None,
                    Name = "'Operation'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'X'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupFAdd = new()
        {
            Op = Op.OpGroupFAdd,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.GroupOperation,
                    Quantifier = Quantifier.None,
                    Name = "'Operation'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'X'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupFMin = new()
        {
            Op = Op.OpGroupFMin,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.GroupOperation,
                    Quantifier = Quantifier.None,
                    Name = "'Operation'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "X"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupUMin = new()
        {
            Op = Op.OpGroupUMin,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.GroupOperation,
                    Quantifier = Quantifier.None,
                    Name = "'Operation'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'X'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupSMin = new()
        {
            Op = Op.OpGroupSMin,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.GroupOperation,
                    Quantifier = Quantifier.None,
                    Name = "'Operation'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "X"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupFMax = new()
        {
            Op = Op.OpGroupFMax,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.GroupOperation,
                    Quantifier = Quantifier.None,
                    Name = "'Operation'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "X"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupUMax = new()
        {
            Op = Op.OpGroupUMax,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.GroupOperation,
                    Quantifier = Quantifier.None,
                    Name = "'Operation'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "X"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupSMax = new()
        {
            Op = Op.OpGroupSMax,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.GroupOperation,
                    Quantifier = Quantifier.None,
                    Name = "'Operation'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "X"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpReadPipe = new()
        {
            Op = Op.OpReadPipe,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpWritePipe = new()
        {
            Op = Op.OpWritePipe,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpReservedReadPipe = new()
        {
            Op = Op.OpReservedReadPipe,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Reserve Id'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Index'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpReservedWritePipe = new()
        {
            Op = Op.OpReservedWritePipe,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Reserve Id'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Index'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpReserveReadPipePackets = new()
        {
            Op = Op.OpReserveReadPipePackets,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Num Packets'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpReserveWritePipePackets = new()
        {
            Op = Op.OpReserveWritePipePackets,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Num Packets'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpCommitReadPipe = new()
        {
            Op = Op.OpCommitReadPipe,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Reserve Id'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpCommitWritePipe = new()
        {
            Op = Op.OpCommitWritePipe,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Reserve Id'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpIsValidReserveId = new()
        {
            Op = Op.OpIsValidReserveId,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Reserve Id'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGetNumPipePackets = new()
        {
            Op = Op.OpGetNumPipePackets,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGetMaxPipePackets = new()
        {
            Op = Op.OpGetMaxPipePackets,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupReserveReadPipePackets = new()
        {
            Op = Op.OpGroupReserveReadPipePackets,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Num Packets'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupReserveWritePipePackets = new()
        {
            Op = Op.OpGroupReserveWritePipePackets,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Num Packets'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupCommitReadPipe = new()
        {
            Op = Op.OpGroupCommitReadPipe,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Reserve Id'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGroupCommitWritePipe = new()
        {
            Op = Op.OpGroupCommitWritePipe,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Reserve Id'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpEnqueueMarker = new()
        {
            Op = Op.OpEnqueueMarker,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Queue'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Num Events'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Wait Events'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Ret Event'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpEnqueueKernel = new()
        {
            Op = Op.OpEnqueueKernel,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Queue'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Flags'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'ND Range'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Num Events'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Wait Events'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Ret Event'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Invoke'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Align'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Local Size'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGetKernelNDrangeSubGroupCount = new()
        {
            Op = Op.OpGetKernelNDrangeSubGroupCount,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'ND Range'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Invoke'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Align'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGetKernelNDrangeMaxSubGroupSize = new()
        {
            Op = Op.OpGetKernelNDrangeMaxSubGroupSize,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'ND Range'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Invoke'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Align'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGetKernelWorkGroupSize = new()
        {
            Op = Op.OpGetKernelWorkGroupSize,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Invoke'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Align'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGetKernelPreferredWorkGroupSizeMultiple = new()
        {
            Op = Op.OpGetKernelPreferredWorkGroupSizeMultiple,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Invoke'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Align'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpRetainEvent = new()
        {
            Op = Op.OpRetainEvent,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Event'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpReleaseEvent = new()
        {
            Op = Op.OpReleaseEvent,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Event'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpCreateUserEvent = new()
        {
            Op = Op.OpCreateUserEvent,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpIsValidEvent = new()
        {
            Op = Op.OpIsValidEvent,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Event'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSetUserEventStatus = new()
        {
            Op = Op.OpSetUserEventStatus,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Event'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Status'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpCaptureEventProfilingInfo = new()
        {
            Op = Op.OpCaptureEventProfilingInfo,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Event'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Profiling Info'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGetDefaultQueue = new()
        {
            Op = Op.OpGetDefaultQueue,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpBuildNDRange = new()
        {
            Op = Op.OpBuildNDRange,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'GlobalWorkSize'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'LocalWorkSize'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'GlobalWorkOffset'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSparseSampleImplicitLod = new()
        {
            Op = Op.OpImageSparseSampleImplicitLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSparseSampleExplicitLod = new()
        {
            Op = Op.OpImageSparseSampleExplicitLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSparseSampleDrefImplicitLod = new()
        {
            Op = Op.OpImageSparseSampleDrefImplicitLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSparseSampleDrefExplicitLod = new()
        {
            Op = Op.OpImageSparseSampleDrefExplicitLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSparseSampleProjImplicitLod = new()
        {
            Op = Op.OpImageSparseSampleProjImplicitLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSparseSampleProjExplicitLod = new()
        {
            Op = Op.OpImageSparseSampleProjExplicitLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSparseSampleProjDrefImplicitLod = new()
        {
            Op = Op.OpImageSparseSampleProjDrefImplicitLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSparseSampleProjDrefExplicitLod = new()
        {
            Op = Op.OpImageSparseSampleProjDrefExplicitLod,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSparseFetch = new()
        {
            Op = Op.OpImageSparseFetch,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSparseGather = new()
        {
            Op = Op.OpImageSparseGather,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Component'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSparseDrefGather = new()
        {
            Op = Op.OpImageSparseDrefGather,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSparseTexelsResident = new()
        {
            Op = Op.OpImageSparseTexelsResident,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Resident Code'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpNoLine = new()
        {
            Op = Op.OpNoLine
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicFlagTestAndSet = new()
        {
            Op = Op.OpAtomicFlagTestAndSet,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpAtomicFlagClear = new()
        {
            Op = Op.OpAtomicFlagClear,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpImageSparseRead = new()
        {
            Op = Op.OpImageSparseRead,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSizeOf = new()
        {
            Op = Op.OpSizeOf,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypePipeStorage = new()
        {
            Op = Op.OpTypePipeStorage,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpConstantPipeStorage = new()
        {
            Op = Op.OpConstantPipeStorage,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Capacity'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpCreatePipeFromPipeStorage = new()
        {
            Op = Op.OpCreatePipeFromPipeStorage,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe Storage'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGetKernelLocalSizeForSubgroupCount = new()
        {
            Op = Op.OpGetKernelLocalSizeForSubgroupCount,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Subgroup Count'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Invoke'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Align'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpGetKernelMaxNumSubgroups = new()
        {
            Op = Op.OpGetKernelMaxNumSubgroups,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Invoke'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Align'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpTypeNamedBarrier = new()
        {
            Op = Op.OpTypeNamedBarrier,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpNamedBarrierInitialize = new()
        {
            Op = Op.OpNamedBarrierInitialize,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Subgroup Count'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpMemoryNamedBarrier = new()
        {
            Op = Op.OpMemoryNamedBarrier,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Named Barrier'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Memory'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpModuleProcessed = new()
        {
            Op = Op.OpModuleProcessed,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'Process'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSubgroupBallotKHR = new()
        {
            Op = Op.OpSubgroupBallotKHR,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Predicate'"
                }
            }
        };

        /// <summary>
        /// </summary>
        public static readonly OpCode OpSubgroupFirstInvocationKHR = new()
        {
            Op = Op.OpSubgroupFirstInvocationKHR,
            Operands = new[]
            {
                new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        };
    }
}
