using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Result is true if x &lt; y or x &gt; y, where IEEE comparisons are used, otherwise result is false.
	/// </summary>
	public class LessOrGreater : FloatBinaryInstruction {
		public override Operation OpCode => Operation.LessOrGreater;
	}
}
