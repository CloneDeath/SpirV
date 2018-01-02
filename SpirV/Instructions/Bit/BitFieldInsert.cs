using SpirV.Native;

namespace SpirV.Instructions.Bit
{
	/// <summary>
	/// Make a copy of an object, with a modified bit field that comes from another object.
	/// Results are computed per component. 
	/// </summary>
	public class BitFieldInsert : BaseInstruction {
		public override int WordCount => 7;
		public override Operation OpCode => Operation.BitFieldInsert;
		
		/// <summary>
		/// Result Type must be a scalar or vector of integer type.
		/// The type of Base and Insert must be the same as Result Type. 
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// The type of Base and Insert must be the same as Result Type.
		/// 
		/// Any result bits numbered outside [Offset, Offset + Count - 1] (inclusive) will come from the
		/// corresponding bits in Base.
		/// </summary>
		public int BaseId { get; set; }
		
		/// <summary>
		/// The type of Base and Insert must be the same as Result Type.
		/// 
		/// Any result bits numbered in [Offset, Offset + Count - 1] come, in order, from the bits
		/// numbered [0, Count - 1] of Insert.
		/// </summary>
		public int InsertId { get; set; }
		
		/// <summary>
		/// Offset must be an integer type scalar.
		/// Offset is the lowest-order bit of the bit field.
		/// It will be consumed as an unsigned value.
		/// 
		/// The resulting value is undefined if Count or Offset or their sum is greater than the number of
		/// bits in the result.
		/// </summary>
		public int OffsetId { get; set; }
		
		/// <summary>
		/// Count must be an integer type scalar.
		/// Count is the number of bits taken from Insert.
		/// It will be consumed as an unsigned value.
		/// Count can be 0, in which case the result will be Base.
		/// 
		/// The resulting value is undefined if Count or Offset or their sum is greater than the number of
		/// bits in the result.
		/// </summary>
		public int CountId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(BaseId);
			ba.PushUInt32(InsertId);
			ba.PushUInt32(OffsetId);
			ba.PushUInt32(CountId);
			return ba.ToArray();
		}
	}
}
