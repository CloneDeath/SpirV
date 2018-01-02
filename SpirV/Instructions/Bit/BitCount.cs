using SpirV.Native;

namespace SpirV.Instructions.Bit
{
	/// <summary>
	/// Count the number of set bits in an object.
	/// 
	/// Results are computed per component.
	/// 
	/// The result is the unsigned value that is the number of bits in Base that are 1.
	/// </summary>
	public class BitCount : BaseInstruction {
		public override int WordCount => 4;
		public override Operation OpCode => Operation.BitCount;
		
		/// <summary>
		/// Result Type must be a scalar or vector of integer type.
		/// The components must be wide enough to hold the unsigned Width of Base as an unsigned value.
		/// That is, no sign bit is needed or counted when checking for a wide enough result width.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Base must be a scalar or vector of integer type.
		/// It must have the same number of components as Result Type.
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
