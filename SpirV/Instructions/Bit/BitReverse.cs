using SpirV.Native;

namespace SpirV.Instructions.Bit
{
	/// <summary>
	/// Reverse the bits in an object.
	/// 
	/// Results are computed per component.
	/// 
	/// The bit-number n of the result will be taken from bit-number Width - 1 - n of Base,
	/// where Width is the OpTypeInt operand of the Result Type.
	/// </summary>
	public class BitReverse : BaseInstruction {
		public override int WordCount => 4;
		public override Operation OpCode => Operation.BitReverse;
		
		/// <summary>
		/// Result Type must be a scalar or vector of integer type. 
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// The type of Base must be the same as Result Type.
		/// </summary>
		public int BaseId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(BaseId);
			return ba.ToArray();
		}
	}
}
