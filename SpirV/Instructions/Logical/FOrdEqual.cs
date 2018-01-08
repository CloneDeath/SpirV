using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Floating-point comparison for being ordered and equal.
	/// </summary>
	public class FOrdEqual : FloatBinaryInstruction {
		public override Operation OpCode => Operation.FOrdEqual;
	}
}
