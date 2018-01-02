using SpirV.Native;

namespace SpirV.Instructions.Conversion
{
	/// <summary>
	/// Convert an integer to pointer.
	/// A Result Type width smaller than the width of Integer Value pointer will truncate.
	/// A Result Type width larger than the width of Integer Value pointer will zero extend. 
	/// </summary>
	public class ConvertUToPtr : BaseInstruction
	{
		public override int WordCount => 4;
		public override Operation OpCode => Operation.ConvertUToPtr;
		
		/// <summary>
		/// Result Type must be an OpTypePointer.
		/// For same-width source and result, this is the same as OpBitcast.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		public int IntegerValueId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(IntegerValueId);
			return ba.ToArray();
		}
	}
}
