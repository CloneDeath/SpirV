using SpirV.Native;

namespace SpirV.Instructions.Function
{
	/// <summary>
	/// Last instruction of a function.
	/// </summary>
	public class FunctionEnd : BaseInstruction
	{
		public override int WordCount => 1;
		public override Operation OpCode => Operation.FunctionEnd;

		protected override byte[] GetParameterBytes() {
			return new byte[0];
		}
	}
}
