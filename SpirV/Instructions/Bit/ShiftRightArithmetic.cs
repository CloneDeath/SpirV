using SpirV.Native;

namespace SpirV.Instructions.Bit
{
	/// <summary>
	/// Shift the bits in Base right by the number of bits specified in Shift.
	/// The most-significant bits will be filled with the sign bit from Base.
	/// 
	/// Results are computed per component.
	/// </summary>
	public class ShiftRightArithmetic : BaseInstruction
	{
		public override int WordCount => 5;
		public override Operation OpCode => Operation.ShiftRightArithmetic;
		
		/// <summary>
		/// Result Type must be a scalar or vector of integer type. 
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// The type of each Base and Shift must be a scalar or vector of integer type.
		/// Base and Shift must have the same number of components.
		/// The number of components and bit width of the type of Base must be the same as in Result Type. 
		/// </summary>
		public int BaseId { get; set; }
		
		/// <summary>
		/// Shift is treated as unsigned.
		/// The type of each Base and Shift must be a scalar or vector of integer type.
		/// Base and Shift must have the same number of components.
		/// The result is undefined if Shift is greater than the bit width of the components of Base. 
		/// </summary>
		public int ShiftId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(BaseId);
			ba.PushUInt32(ShiftId);
			return ba.ToArray();
		}
	}
}
