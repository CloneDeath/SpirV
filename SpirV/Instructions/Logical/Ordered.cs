using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Result is true if both x == x and y == y are true, where IEEE comparison is used, otherwise result is false.
	/// </summary>
	public class Ordered : FloatBinaryInstruction {
		public override Operation OpCode => Operation.Ordered;
	}
}
