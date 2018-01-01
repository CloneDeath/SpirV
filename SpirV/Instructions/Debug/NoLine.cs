using SpirV.Native;

namespace SpirV.Instructions.Debug
{
	/// <summary>
	/// Discontinue any source-level location information that might be active from a previous OpLine instruction.
	/// This has no semantic impact and can safely be removed from a module.
	/// This instruction can only appear after the annotation instructions (see the Logical Layout section).
	/// It cannot be the last instruction in a block,
	/// or the second-to-last instruction if the block has a merge instruction.
	/// There is not a requirement that there is a preceding OpLine instruction.
	/// </summary>
	public class NoLine : BaseInstruction
	{
		public override int WordCount => 1;
		public override Operation OpCode => Operation.NoLine;

		protected override byte[] GetParameterBytes() {
			return new byte[0];
		}
	}
}
