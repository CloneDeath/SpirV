using SpirV.Native;

namespace SpirV.Instructions.Conversion
{
	/// <summary>
	/// Quantize a floating-point value to what is expressible by a 16-bit floating-point value.
	/// The RelaxedPrecision Decoration has no effect on this instruction.
	/// Results are computed per component.
	/// </summary>
	public class QuantizeToF16 : BaseInstruction {
		public override int WordCount => 4;
		public override Operation OpCode => Operation.QuantizeToF16;
		
		/// <summary>
		/// Result Type must be a scalar or vector of floating-point type.
		/// The component width must be 32 bits.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Value is the value to quantize.
		/// The type of Value must be the same as Result Type.
		/// If Value is an infinity, the result is the same infinity.
		/// If Value is a NaN, the result is a NaN, but not necessarily the same NaN.
		/// If Value is positive with a magnitude too large to represent as a 16-bit floating-point value,
		/// the result is positive infinity.
		/// If Value is negative with a magnitude too large to represent as a 16-bit floating-point value,
		/// the result is negative infinity.
		/// If the magnitude of Value is too small to represent as a normalized 16-bit floating-point value,
		/// the result may be either +0 or -0.
		/// </summary>
		public int ValueId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(ValueId);
			return ba.ToArray();
		}
	}
}
