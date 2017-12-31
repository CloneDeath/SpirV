using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare a new pointer type.
	/// </summary>
	public class TypePointer :BaseInstruction
	{
		public TypePointer(int resultId, StorageClass storageClass, int typeId) {
			ResultId = resultId;
			StorageClass = storageClass;
			TypeId = typeId;
		}

		public override int WordCount => 4;
		public override Operation OpCode => Operation.TypePointer;

		public int ResultId { get; set; }

		/// <summary>
		/// Storage Class is the Storage Class of the memory holding the object pointed to.
		/// If there was a forward reference to this type from an OpTypeForwardPointer, 
		/// the Storage Class of that instruction must equal the Storage Class of this instruction.
		/// </summary>
		public StorageClass StorageClass { get; set; }

		/// <summary>
		/// Type is the type of the object pointed to.
		/// </summary>
		public int TypeId { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushUInt32((uint)StorageClass);
			byteArray.PushUInt32((uint)TypeId);
			return byteArray.ToArray();
		}
	}
}
