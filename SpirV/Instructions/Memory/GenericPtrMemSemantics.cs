using SpirV.Native;

namespace SpirV.Instructions.Memory
{
	/// <summary>
	/// Result is a valid Memory Semantics which includes mask bits set for the Storage Class for
	/// the specific (non-Generic) Storage Class of Pointer. 
	/// </summary>
	public class GenericPtrMemSemantics : BaseInstruction {
		public override int WordCount => 4;
		public override Operation OpCode => Operation.GenericPtrMemSemantics;
		
		/// <summary>
		/// Result Type must be an OpTypeInt with 32-bit Width and 0 Signedness.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Pointer must point to Generic Storage Class.
		/// </summary>
		public int PointerId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint) ResultTypeId);
			byteArray.PushUInt32((uint) ResultId);
			byteArray.PushUInt32((uint) PointerId);
			return byteArray.ToArray();
		}
	}
}
