using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Floating-point comparison if operands are ordered and Operand 1 is greater than or equal to Operand 2.
	/// </summary>
	public class FOrdGreaterThanEqual : FloatBinaryInstruction {
		public override Operation OpCode => Operation.FOrdGreaterThanEqual;
	}
}
