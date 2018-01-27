using SpirV.Native;

namespace SpirV.Instructions.ControlFlow
{
	/// <summary>
	/// Return a value from a function.
	/// 
	/// This instruction must be the last instruction in a block.
	/// </summary>
	public class ReturnValue : BaseInstruction {
		public override int WordCount => 2;
		public override Operation OpCode => Operation.ReturnValue;
		
		/// <summary>
		/// Value is the value returned, by copy, and must match the Return Type operand
		/// of the OpTypeFunction type of the OpFunction body this return instruction is in.
		/// </summary>
		public int ValueId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ValueId);
			return ba.ToArray();
		}
	}
}
