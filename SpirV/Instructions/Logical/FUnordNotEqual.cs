using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Floating-point comparison for being unordered or not equal.
	/// </summary>
	public class FUnordNotEqual : FloatBinaryInstruction {
		public override Operation OpCode => Operation.FUnordNotEqual;
	}
}
