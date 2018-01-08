using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Floating-point comparison for being ordered and not equal.
	/// </summary>
	public class FOrdNotEqual : FloatBinaryInstruction {
		public override Operation OpCode => Operation.FOrdNotEqual;
	}
}
