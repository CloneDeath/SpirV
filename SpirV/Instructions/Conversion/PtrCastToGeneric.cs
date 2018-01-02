using SpirV.Native;

namespace SpirV.Instructions.Conversion
{
	/// <summary>
	/// Convert a pointer’s Storage Class to Generic.
	/// </summary>
	public class PtrCastToGeneric : BaseInstruction
	{
		public override int WordCount => 4;
		public override Operation OpCode => Operation.PtrCastToGeneric;
		
		/// <summary>
		/// Result Type must be an OpTypePointer.
		/// Its Storage Class must be Generic.
		/// Result Type and Pointer must point to the same type.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Pointer must point to the Workgroup, CrossWorkgroup, or Function Storage Class.
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
