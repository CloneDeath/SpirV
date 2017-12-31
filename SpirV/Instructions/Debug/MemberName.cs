using SpirV.Native;

namespace SpirV.Instructions.Debug
{
	/// <summary>
	/// Assign a name string to a member of a structure type. This has no semantic impact and can safely be removed from a module.
	/// </summary>
	public class MemberName : BaseInstruction
	{
		public MemberName():this(0, 0, "") { }

		public MemberName(int typeId, int member, string name) {
			TypeId = typeId;
			Member = member;
			Name = name;
		}

		public override int WordCount => 3 + ByteArray.GetWordCount(Name);
		public override Operation OpCode => Operation.MemberName;

		/// <summary>
		/// Type is the id from an OpTypeStruct instruction.
		/// </summary>
		public int TypeId { get; set; }

		/// <summary>
		/// Member is the number of the member to assign in the structure.
		/// The first member is member 0, the next is member 1,... This literal operand is limited to a single word.
		/// </summary>
		public int Member { get; set; }

		/// <summary>
		/// Name is the string to assign to the member.
		/// </summary>
		public string Name { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)TypeId);
			byteArray.PushUInt32((uint)Member);
			byteArray.PushString(Name);
			return byteArray.ToArray();
		}
	}
}
