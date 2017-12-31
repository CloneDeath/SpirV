using SpirV.Native;

namespace SpirV.Instructions.Memory
{
	/// <summary>
	/// Load through a pointer.
	/// </summary>
	public class Load : BaseInstruction
	{
		public Load(int resultTypeId, int resultId, int pointerId, MemoryAccess? memoryAccess = null) {
			ResultTypeId = resultTypeId;
			ResultId = resultId;
			PointerId = pointerId;
			MemoryAccess = memoryAccess;
		}

		public override int WordCount => 4 + (MemoryAccess != null ? 1 : 0);
		public override Operation OpCode => Operation.Load;

		/// <summary>
		/// Result Type is the type of the loaded object.
		/// </summary>
		public int ResultTypeId { get; set; }
		public int ResultId { get; set; }

		/// <summary>
		/// Pointer is the pointer to load through.Its type must be an OpTypePointer whose
		/// Type operand is the same as Result Type.
		/// </summary>
		public int PointerId { get; set; }

		/// <summary>
		/// Memory Access must be a Memory Access literal.If not present, it is the same as specifying None.
		/// </summary>
		public MemoryAccess? MemoryAccess { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultTypeId);
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushUInt32((uint)PointerId);
			if (MemoryAccess != null) byteArray.PushUInt32((uint)MemoryAccess);
			return byteArray.ToArray();
		}
	}
}
