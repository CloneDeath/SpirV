using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare a new floating-point type.
	/// </summary>
	public class TypeFloat : BaseInstruction
	{
		public TypeFloat(int resultId, int width) {
			ResultId = resultId;
			Width = width;
		}

		public override int WordCount => 3;
		public override Operation OpCode => Operation.TypeFloat;

		public int ResultId { get; set; }

		/// <summary>
		/// Width specifies how many bits wide the type is. The bit pattern of a
		/// floating-point value is as described by the IEEE 754 standard.
		/// </summary>
		public int Width { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushUInt32((uint)Width);
			return byteArray.ToArray();
		}
	}
}
