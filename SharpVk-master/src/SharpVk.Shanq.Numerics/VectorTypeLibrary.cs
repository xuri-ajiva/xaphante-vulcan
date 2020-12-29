using System;
using System.Collections.Generic;
using System.Numerics;

namespace SharpVk.Shanq.Numerics
{
    public class VectorTypeLibrary
        : IVectorTypeLibrary
    {
        private static readonly Dictionary<Type, Format> VectorFormats = new Dictionary<Type, Format>
        {
            [typeof(float)] = Format.R32SFloat,
            [typeof(Vector2)] = Format.R32G32SFloat,
            [typeof(Vector3)] = Format.R32G32B32SFloat,
            [typeof(Vector4)] = Format.R32G32B32A32SFloat,
            [typeof(int)] = Format.R32SInt,
            [typeof(uint)] = Format.R32UInt
        };

        public static readonly VectorTypeLibrary Instance = new VectorTypeLibrary();

        public Type GetMatrixRowType(Type value)
        {
            return typeof(float);
        }

        public Type GetVectorElementType(Type value)
        {
            return typeof(float);
        }

        public int GetVectorLength(Type value)
        {
            if (value == typeof(Vector2))
                return 2;
            if (value == typeof(Vector3))
                return 3;
            if (value == typeof(Vector4))
                return 4;
            throw new ArgumentException("Invalid vector type.", "value");
        }

        public int[] GetMatrixDimensions(Type value)
        {
            if (value == typeof(Matrix3x2))
                return new[]
                {
                    3, 2
                };
            if (value == typeof(Matrix4x4))
                return new[]
                {
                    4, 4
                };
            throw new ArgumentException("Invalid vector type.", "value");
        }

        public bool IsVectorType(Type type)
        {
            return type == typeof(Vector2)
                   || type == typeof(Vector3)
                   || type == typeof(Vector4);
        }

        public bool IsMatrixType(Type type)
        {
            return type == typeof(Matrix3x2)
                   || type == typeof(Matrix4x4);
        }

        public IEnumerable<int> GetSwizzle(Type type, string name)
        {
            if (name.Length > 4) return null;

            var result = new List<int>();

            for (var index = 0; index < name.Length; index++)
                switch (name[index])
                {
                    case 'X':
                        result.Add(0);
                        break;
                    case 'Y':
                        result.Add(1);
                        break;
                    case 'Z':
                        result.Add(2);
                        break;
                    case 'W':
                        result.Add(3);
                        break;
                }

            return result;
        }

        public Format GetVectorFormat(Type type)
        {
            if (VectorFormats.TryGetValue(type, out var result))
                return result;
            throw new NotSupportedException();
        }
    }
}
