using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare the Storage Class for a forward reference to a pointer.
	/// </summary>
	public class TypeForwardPointer : BaseInstruction {
		public override int WordCount => 3;
		public override Operation OpCode => Operation.TypeForwardPointer;
		
		/// <summary>
		/// Pointer Type is a forward reference to the result of an OpTypePointer.
		/// The type of object the pointer points to is declared by the OpTypePointer instruction,
		/// not this instruction.
		/// Subsequent OpTypeStruct instructions can use Pointer Type as an operand.
		/// </summary>
		public int PointerTypeId { get; set; }
		
		/// <summary>
		/// Storage Class is the Storage Class of the memory holding the object pointed to.
		/// </summary>
		public StorageClass StorageClass { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint) PointerTypeId);
			byteArray.PushUInt32((uint) StorageClass);
			return byteArray.ToArray();
		}
	}
}
