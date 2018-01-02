using SpirV.Native;

namespace SpirV.Instructions.Conversion
{
	/// <summary>
	/// Convert (value preserving) signed width.
	/// This is either a truncate or a sign extend.
	/// Results are computed per component.
	/// </summary>
	public class SConvert : BaseInstruction
	{
		public override int WordCount => 4;
		public override Operation OpCode => Operation.SConvert;
		
		/// <summary>
		/// Result Type must be a scalar or vector of integer type. 
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Signed Value must be a scalar or vector of integer type.
		/// It must have the same number of components as Result Type.
		/// The component width cannot equal the component width in Result Type. 
		/// </summary>
		public int SignedValueId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(SignedValueId);
			return ba.ToArray();
		}
	}
}
