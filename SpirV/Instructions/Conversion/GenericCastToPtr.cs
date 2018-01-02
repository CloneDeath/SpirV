using SpirV.Native;

namespace SpirV.Instructions.Conversion
{
	/// <summary>
	/// Convert a pointer’s Storage Class to a non-Generic class.
	/// </summary>
	public class GenericCastToPtr : BaseInstruction
	{
		public override int WordCount => 4;
		public override Operation OpCode => Operation.GenericCastToPtr;
		
		/// <summary>
		/// Result Type must be an OpTypePointer.
		/// Its Storage Class must be Workgroup, CrossWorkgroup, or Function.
		/// Result Type and Pointer must point to the same type.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Pointer must point to the Generic Storage Class.
		/// Result Type and Pointer must point to the same type.
		/// </summary>
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
