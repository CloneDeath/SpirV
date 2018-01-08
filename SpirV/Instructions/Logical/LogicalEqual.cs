using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Result is true if Operand 1 and Operand 2 have the same value.
	/// Result is false if Operand 1 and Operand 2 have different values.
	/// </summary>
	public class LogicalEqual : BooleanBinaryInstruction {
		public override Operation OpCode => Operation.LogicalEqual;
	}
}
