using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Result is true if either x or y is an IEEE NaN, otherwise result is false.
	/// </summary>
	public class Unordered : FloatBinaryInstruction {
		public override Operation OpCode => Operation.Unordered;
	}
}
