using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Result is true if x is an IEEE finite number, otherwise result is false.
	/// </summary>
	public class IsFinite : FloatUnaryInstruction {
		public override Operation OpCode => Operation.IsFinite;
	}
}
