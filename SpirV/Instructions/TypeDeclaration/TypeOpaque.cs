using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare a structure type with no body specified.
	/// </summary>
	public class TypeOpaque : BaseInstruction {
		public TypeOpaque() : this(0, "\0") {}
		public TypeOpaque(int resultId, string name) {
			ResultId = resultId;
			Name = name;
		}
		
		public override int WordCount => 2 + ByteArray.GetWordCount(Name);
		public override Operation OpCode => Operation.TypeOpaque;
		
		public int ResultId { get; set; }
		public string Name { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushString(Name);
			return byteArray.ToArray();
		}
	}
}
