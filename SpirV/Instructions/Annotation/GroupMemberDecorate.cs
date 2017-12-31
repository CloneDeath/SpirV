using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.Annotation
{
	/// <summary>
	/// Add a group of Decorations to members of structure types.
	/// </summary>
	public class GroupMemberDecorate : BaseInstruction
	{
		public GroupMemberDecorate() : this(0) { }
		public GroupMemberDecorate(int decorationGroup, params GroupMember[] targets) {
			DecorationGroup = decorationGroup;
			Targets = targets;
		}

		public override int WordCount => 2 + (Targets.Length * 2);
		public override Operation OpCode => Operation.GroupMemberDecorate;

		/// <summary>
		/// Decoration Group is the id of an OpDecorationGroup instruction.
		/// </summary>
		public int DecorationGroup { get; set; }

		/// <summary>
		/// Targets is a list of (id, Member) pairs to decorate with the groups of decorations.
		/// Each id in the pair must be a target structure type, and the associated Member is 
		/// the number of the member to decorate in the type. The first member is member 0, 
		/// the next is member 1,...
		/// </summary>
		public GroupMember[] Targets { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)DecorationGroup);
			foreach (var groupMember in Targets) {
				byteArray.PushUInt32((uint)groupMember.Id);
				byteArray.PushUInt32((uint)groupMember.Member);
			}
			return byteArray.ToArray();
		}
	}

	public class GroupMember
	{
		public GroupMember():this(0, 0) { }
		public GroupMember(int id, int member) {
			Id = id;
			Member = member;
		}

		public int Id { get; set; }
		public int Member { get; set; }
	}
}
