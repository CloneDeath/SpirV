using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Result is true if Operand 1 and Operand 2 have different values.
	/// Result is false if Operand 1 and Operand 2 have the same value.
	/// </summary>
	public class LogicalNotEqual : BooleanBinaryInstruction {
		public override Operation OpCode => Operation.LogicalNotEqual;
	}
}
