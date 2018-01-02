using SpirV.Native;

namespace SpirV.Instructions.Bit
{
	/// <summary>
	/// Extract a bit field from an object, with sign extension.
	/// 
	/// Results are computed per component. 
	/// </summary>
	public class BitFieldSExtract : BaseInstruction {
		public override int WordCount => 6;
		public override Operation OpCode => Operation.BitFieldSExtract;
		
		/// <summary>
		/// The type of Base must be the same as Result Type. 
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// The type of Base must be the same as Result Type. 
		/// </summary>
		public int BaseId { get; set; }
		
		/// <summary>
		/// Offset must be an integer type scalar.
		/// Offset is the lowest-order bit of the bit field to extract from Base.
		/// It will be consumed as an unsigned value.
		/// 
		/// The resulting value is undefined if Count or Offset or their sum is greater than the number of bits
		/// in the result.
		/// </summary>
		public int OffsetId { get; set; }
		
		/// <summary>
		/// If Count is greater than 0: The bits of Base numbered in [Offset, Offset + Count - 1] (inclusive)
		/// become the bits numbered [0, Count - 1] of the result.
		/// The remaining bits of the result will all be the same as bit Offset + Count - 1 of Base.
		/// 
		/// Count must be an integer type scalar.
		/// Count is the number of bits extracted from Base.
		/// It will be consumed as an unsigned value.
		/// Count can be 0, in which case the result will be 0.
		/// 
		/// The resulting value is undefined if Count or Offset or their sum is greater than the number of bits
		/// in the result.
		/// </summary>
		public int CountId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(BaseId);
			ba.PushUInt32(OffsetId);
			ba.PushUInt32(CountId);
			return ba.ToArray();
		}
	}
}
