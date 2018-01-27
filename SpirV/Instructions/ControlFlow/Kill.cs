using SpirV.Native;

namespace SpirV.Instructions.ControlFlow
{
	/// <summary>
	/// Fragment-shader discard.
	/// 
	/// Ceases all further processing in any invocation that executes it:
	/// Only instructions these invocations executed before OpKill will have observable side effects.
	/// If this instruction is executed in non-uniform control flow,
	/// all subsequent control flow is non-uniform (for invocations that continue to execute).
	/// This instruction must be the last instruction in a block.
	/// This instruction is only valid in the Fragment Execution Model.
	/// </summary>
	public class Kill : BaseInstruction {
		public override int WordCount => 1;
		public override Operation OpCode => Operation.Kill;
		
		protected override byte[] GetParameterBytes() {
			return new byte[0];
		}
	}
}
