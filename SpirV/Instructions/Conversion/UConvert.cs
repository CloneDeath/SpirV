using SpirV.Native;

namespace SpirV.Instructions.Conversion
{
	/// <summary>
	/// Convert (value preserving) unsigned width.
	/// This is either a truncate or a zero extend.
	/// Results are computed per component.
	/// </summary>
	public class UConvert : BaseInstruction
	{
		public override int WordCount => 4;
		public override Operation OpCode => Operation.UConvert;
		
		/// <summary>
		/// Result Type must be a scalar of integer type, whose Signedness operand is 0. 
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Unsigned Value must be a scalar or vector of integer type.
		/// It must have the same number of components as Result Type.
		/// The component width cannot equal the component width in Result Type. 
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
