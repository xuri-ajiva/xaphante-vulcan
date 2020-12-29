using System;
using System.Linq;

namespace SharpVk.Spirv
{
    /// <summary>
    ///     Represents a single line of a SPIR-V shader file.
    /// </summary>
    public class SpirvStatement
    {
        /// <summary>
        ///     Create a new SPIR-V statement with the specified opcode &amp;
        ///     operand arguments.
        /// </summary>
        /// <param name="op">
        ///     The opcode for this statement.
        /// </param>
        /// <param name="operands">
        ///     The arguments for any operands of the specified opcode.
        /// </param>
        public SpirvStatement(Op op, params object[] operands)
        {
            if (operands.Any(x => x.GetType().IsArray)) throw new ArgumentException("Array passed as operand");

            Op = op;
            Operands = operands;
        }

        /// <summary>
        ///     The Opcode for this statement.
        /// </summary>
        public Op Op
        {
            get;
        }

        /// <summary>
        ///     The operands arguments for this statement.
        /// </summary>
        public object[] Operands
        {
            get;
        }

        /// <summary>
        ///     Returns a string representation of this statement.
        /// </summary>
        /// <returns>
        ///     A string representation of this statement.
        /// </returns>
        public override string ToString()
        {
            return Op + Operands.Select(x => " " + FormatOperand(x)).Aggregate("", (x, y) => x + y);
        }

        private string FormatOperand(object operand)
        {
            if (operand.GetType() == typeof(string))
                return $"\"{operand}\"";
            return operand.ToString();
        }

        /// <summary>
        ///     Determines whether the specified object is equal (by value) to this
        ///     instance.
        /// </summary>
        /// <param name="obj">
        ///     The object to which to compare.
        /// </param>
        /// <returns>
        ///     True if the instances are equal by value; else false.
        /// </returns>
        public override bool Equals(object obj)
        {
            var other = obj as SpirvStatement;

            if (!ReferenceEquals(other, null)
                && Op == other.Op
                && Operands.Length == other.Operands.Length)
            {
                for (var index = 0; index < Operands.Length; index++)
                    if (!Operands[index].Equals(other.Operands[index]))
                        return false;

                return true;
            }

            return false;
        }

        /// <summary>
        ///     Returns a hashcode for the value of this instance.
        /// </summary>
        /// <returns>
        ///     A 32-bit signed integer hash value.
        /// </returns>
        public override int GetHashCode()
        {
            if (!Operands.Any())
                return Op.GetHashCode();
            return Op.GetHashCode()
                   ^ Operands.Select(x => x.GetHashCode())
                       .Aggregate((x, y) => x ^ y);
        }

        /// <summary>
        ///     Determines whether the specified objects are equal (by value).
        /// </summary>
        /// <param name="left">
        ///     The first value to compare.
        /// </param>
        /// <param name="right">
        ///     The second value to compare.
        /// </param>
        /// <returns>
        ///     True if the instances are equal by value; else false.
        /// </returns>
        public static bool operator ==(SpirvStatement left, SpirvStatement right)
        {
            if (ReferenceEquals(left, null))
                return ReferenceEquals(right, null);
            return left.Equals(right);
        }

        /// <summary>
        ///     Determines whether the specified objects are not equal (by value).
        /// </summary>
        /// <param name="left">
        ///     The first value to compare.
        /// </param>
        /// <param name="right">
        ///     The second value to compare.
        /// </param>
        /// <returns>
        ///     True if the instances are not equal by value; else false.
        /// </returns>
        public static bool operator !=(SpirvStatement left, SpirvStatement right)
        {
            return !(left == right);
        }
    }
}