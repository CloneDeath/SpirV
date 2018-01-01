using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare a new run-time array type. Its length is not known at compile time.
	/// See OpArrayLength for getting the Length of an array of this type.
	/// Objects of this type can only be created with OpVariable using the Uniform Storage Class.
	/// </summary>
	public class TypeRuntimeArray : BaseInstruction {
		public override int WordCount => 3;
		public override Operation OpCode => Operation.TypeRuntimeArray;
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Element Type is the type of each element in the array. It must be a concrete type.
		/// </summary>
		public int ElementTypeId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushUInt32((uint)ElementTypeId);
			return byteArray.ToArray();
		}
	}
}
