using SpirV.Native;

namespace SpirV.Instructions.Conversion
{
	// ReSharper disable once InconsistentNaming
	/// <summary>
	/// Convert (value preserving) from floating point to signed integer, with round toward 0.0.
	/// Results are computed per component.
	/// </summary>
	public class ConvertFToS : BaseInstruction
	{
		public override int WordCount => 4;
		public override Operation OpCode => Operation.ConvertFToS;
		
		/// <summary>
		/// Result Type must be a scalar or vector of integer type. 
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Float Value must be a scalar or vector of floating-point type.
		/// It must have the same number of components as Result Type. 
		/// </summary>
		public int FloatValueId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(FloatValueId);
			return ba.ToArray();
		}
	}
}
