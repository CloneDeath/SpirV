using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Floating-point comparison if operands are ordered and Operand 1 is greater than Operand 2.
	/// </summary>
	public class FOrdGreaterThan : FloatBinaryInstruction {
		public override Operation OpCode => Operation.FOrdGreaterThan;
	}
}
