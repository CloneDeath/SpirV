using SpirV.Native;

namespace SpirV.Instructions.Conversion
{
	/// <summary>
	/// Convert a pointer to an unsigned integer type.
	/// A Result Type width larger than the width of Pointer will zero extend.
	/// A Result Type smaller than the width of Pointer will truncate.
	/// For same-width source and result, this is the same as OpBitcast. 
	/// </summary>
	public class ConvertPtrToU : BaseInstruction
	{
		public override int WordCount => 4;
		public override Operation OpCode => Operation.ConvertPtrToU;
		
		/// <summary>
		/// Result Type must be a scalar or vector of integer type, whose Signedness operand is 0.
		/// </summary>
		public int ResultTypeId { get; set; }
		public int ResultId { get; set; }
		public int PointerId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(PointerId);
			return ba.ToArray();
		}
	}
}
