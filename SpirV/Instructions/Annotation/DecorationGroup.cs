using SpirV.Native;

namespace SpirV.Instructions.Annotation
{
	/// <summary>
	/// A collector for Decorations from OpDecorate instructions. All such OpDecorate
	/// instructions targeting this OpDecorationGroup instruction must precede it.
	/// Subsequent OpGroupDecorate and OpGroupMemberDecorate instructions consume 
	/// this instruction’s Result id to apply multiple decorations to multiple targets.
	/// </summary>
	public class DecorationGroup : BaseInstruction
	{
		public DecorationGroup() : this(0) { }
		public DecorationGroup(int resultId) {
			ResultId = resultId;
		}

		public override int WordCount => 2;
		public override Operation OpCode => Operation.DecorationGroup;

		public int ResultId { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultId);
			return byteArray.ToArray();
		}
	}
}
