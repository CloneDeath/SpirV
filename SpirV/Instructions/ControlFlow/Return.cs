using SpirV.Native;

namespace SpirV.Instructions.ControlFlow
{
	/// <summary>
	/// Return with no value from a function with void return type.
	/// 
	/// This instruction must be the last instruction in a block.
	/// </summary>
	public class Return : BaseInstruction
	{
		public override int WordCount => 1;
		public override Operation OpCode => Operation.Return;

		protected override byte[] GetParameterBytes() {
			return new byte[0];
		}
	}
}
