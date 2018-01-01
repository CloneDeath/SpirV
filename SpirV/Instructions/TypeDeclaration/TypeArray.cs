using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare a new array type: a dynamically-indexable ordered aggregate of elements all having the same type.
	/// </summary>
	public class TypeArray : BaseInstruction
	{
		public TypeArray() : this(0, 0, 0) {}
		public TypeArray(int resultId, int elementTypeId, int lengthId) {
			ResultId = resultId;
			ElementTypeId = elementTypeId;
			LengthId = lengthId;
		}
		
		public override int WordCount => 4;
		public override Operation OpCode => Operation.TypeArray;
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Element Type is the type of each element in the array.
		/// </summary>
		public int ElementTypeId { get; set; }
		
		/// <summary>
		/// Length is the number of elements in the array.
		/// It must be at least 1.
		/// Length must come from a constant instruction of an integer-type scalar whose value is at least 1.
		/// </summary>
		public int LengthId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushUInt32((uint)ElementTypeId);
			byteArray.PushUInt32((uint)LengthId);
			return byteArray.ToArray();
		}
	}
}
