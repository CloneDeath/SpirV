using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Signed-integer comparison if Operand 1 is less than Operand 2.
	/// </summary>
	public class SLessThan : IntegerBinaryInstruction {
		public override Operation OpCode => Operation.SLessThan;
	}
}
