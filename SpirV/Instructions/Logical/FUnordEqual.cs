using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Floating-point comparison for being unordered or equal.
	/// </summary>
	public class FUnordEqual : FloatBinaryInstruction {
		public override Operation OpCode => Operation.FUnordEqual;
	}
}
