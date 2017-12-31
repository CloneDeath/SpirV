using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.Memory
{
	/// <summary>
	/// Store through a pointer.
	/// </summary>
	public class Store : BaseInstruction
	{
		public Store(int pointerId, int objectId, MemoryAccess? memoryAccess = null) {
			PointerId = pointerId;
			ObjectId = objectId;
			MemoryAccess = memoryAccess;
		}

		public override int WordCount => 3 + (MemoryAccess != null ? 1 : 0);
		public override Operation OpCode => Operation.Store;

		/// <summary>
		/// Pointer is the pointer to store through.
		/// Its type must be an OpTypePointer whose Type operand is the same as the type of Object.
		/// </summary>
		public int PointerId { get; set; }

		/// <summary>
		/// Object is the object to store.
		/// </summary>
		public int ObjectId { get; set; }

		/// <summary>
		/// Memory Access must be a Memory Access literal.If not present, it is the same as specifying None.
		/// </summary>
		public MemoryAccess? MemoryAccess { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)PointerId);
			byteArray.PushUInt32((uint)ObjectId);
			if (MemoryAccess != null) byteArray.PushUInt32((uint)MemoryAccess);
			return byteArray.ToArray();
		}
	}
}
