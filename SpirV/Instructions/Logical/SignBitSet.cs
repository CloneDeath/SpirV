using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Result is true if x has its sign bit set, otherwise result is false.
	/// </summary>
	public class SignBitSet : FloatUnaryInstruction {
		public override Operation OpCode => Operation.SignBitSet;
	}
}
