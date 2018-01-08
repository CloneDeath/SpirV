using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Result is true if either Operand 1 or Operand 2 is true.
	/// Result is false if both Operand 1 and Operand 2 are false.
	/// </summary>
	public class LogicalOr : BooleanBinaryInstruction {
		public override Operation OpCode => Operation.LogicalOr;
	}
}
