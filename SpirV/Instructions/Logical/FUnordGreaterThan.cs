using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Floating-point comparison if operands are unordered or Operand 1 is greater than Operand 2.
	/// </summary>
	public class FUnordGreaterThan : FloatBinaryInstruction {
		public override Operation OpCode => Operation.FUnordGreaterThan;
	}
}
