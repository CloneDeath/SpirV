using SpirV.Native;

namespace SpirV.Instructions.Conversion
{
	// ReSharper disable once InconsistentNaming
	/// <summary>
	/// Convert an unsigned integer to signed integer.
	/// Converted values outside the representable range of Result Type are clamped to the nearest
	/// representable value of Result Type.
	/// Results are computed per component.
	/// </summary>
	public class SatConvertUToS : BaseInstruction
	{
		public override int WordCount => 4;
		public override Operation OpCode => Operation.SatConvertUToS;
		
		/// <summary>
		/// Result Type must be a scalar or vector of integer type. 
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Unsigned Value must be a scalar or vector of integer type.
		/// It must have the same number of components as Result Type. 
		/// </summary>
		public int UnsignedValueId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(UnsignedValueId);
			return ba.ToArray();
		}
	}
}
