using SpirV.Native;

namespace SpirV.Instructions.Memory
{
	/// <summary>
	/// Allocate an object in memory, resulting in a pointer to it, which can be used with OpLoad and OpStore.
	/// </summary>
	public class Variable : BaseInstruction
	{
		public Variable(int resultType, int resultId, StorageClass storageClass, int? initializerId = null) {
			ResultType = resultType;
			ResultId = resultId;
			StorageClass = storageClass;
			InitializerId = initializerId;
		}
		public override int WordCount => 4 + (InitializerId != null ? 1 : 0);
		public override Operation OpCode => Operation.Variable;

		/// <summary>
		/// Result Type must be an OpTypePointer. Its Type operand is the type of object in memory.
		/// </summary>
		public int ResultType { get; set; }

		public int ResultId { get; set; }

		/// <summary>
		/// Storage Class is the Storage Class of the memory holding the object. It cannot be Generic.
		/// </summary>
		public StorageClass StorageClass { get; set; }

		/// <summary>
		/// Initializer is optional.
		/// If Initializer is present, it will be the initial value of the variable’s memory content.
		/// Initializer must be an id from a constant instruction or a global (module scope) OpVariable instruction.
		/// Initializer must have the same type as the type pointed to by Result Type.
		/// </summary>
		public int? InitializerId { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultType);
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushUInt32((uint)StorageClass);
			if (InitializerId != null) byteArray.PushUInt32((uint)InitializerId);
			return byteArray.ToArray();
		}
	}
}
