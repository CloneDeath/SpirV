using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare a new vector type.
	/// Components are numbered consecutively, starting with 0.
	/// </summary>
	public class TypeVector : BaseInstruction
	{
		public TypeVector() : this(0, 0, 3) { }
		public TypeVector(int resultId, int componentType, int componentCount) {
			ResultId = resultId;
			ComponentType = componentType;
			ComponentCount = componentCount;
		}

		public override int WordCount => 4;
		public override Operation OpCode => Operation.TypeVector;

		public int ResultId { get; set; }

		/// <summary>
		/// Component Type is the type of each component in the resulting type.It must be a scalar type.
		/// </summary>
		public int ComponentType { get; set; }

		/// <summary>
		/// Component Count is the number of components in the resulting type.It must be at least 2.
		/// </summary>
		public int ComponentCount { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushUInt32((uint)ComponentType);
			byteArray.PushUInt32((uint)ComponentCount);
			return byteArray.ToArray();
		}
	}
}
