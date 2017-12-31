using SpirV.Native;

namespace SpirV.Instructions.Miscellaneous
{
	/// <summary>
	/// This has no semantic impact and can safely be removed from a module.
	/// </summary>
	public class Nop : BaseInstruction
	{
		public override int WordCount => 1;
		public override Operation OpCode => Operation.NoLine;

		protected override byte[] GetParameterBytes() {
			return new byte[0];
		}
	}
}
