using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Result is true if Operand is false.
	/// Result is false if Operand is true.
	/// </summary>
	public class LogicalNot : BooleanUnaryInstruction {
		public override Operation OpCode => Operation.LogicalNot;
	}
}
