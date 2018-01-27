using SpirV.Native;

namespace SpirV.Instructions.ControlFlow
{
	/// <summary>
	/// Declares that this block is not reachable in the CFG.
	/// 
	/// This instruction must be the last instruction in a block.
	/// </summary>
	public class Unreachable : BaseInstruction {
		public override int WordCount => 1;
		public override Operation OpCode => Operation.Unreachable;
		protected override byte[] GetParameterBytes() {
			return new byte[0];
		}
	}
}
