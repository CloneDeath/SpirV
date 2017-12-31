using System;
using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.Annotation
{
	/// <summary>
	/// Add a Decoration to a member of a structure type.
	/// </summary>
	public class MemberDecorate : BaseInstruction
	{
		public MemberDecorate() : this(0, 0, Decoration.Max) { }
		public MemberDecorate(int structureType, int member, Decoration decoration, params int[] literals) {
			StructureType = structureType;
			Member = member;
			Decoration = decoration;
			Literals = literals;
		}

		public override int WordCount => 4 + Literals.Length;
		public override Operation OpCode => Operation.MemberDecorate;

		/// <summary>
		/// Structure type is the id of a type from OpTypeStruct.
		/// </summary>
		public int StructureType { get; set; }

		/// <summary>
		/// Member is the number of the member to decorate in the type.
		/// The first member is member 0, the next ismember 1,...
		/// </summary>
		public int Member { get; set; }
		public Decoration Decoration { get; set; }
		public int[] Literals { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)StructureType);
			byteArray.PushUInt32((uint)Member);
			byteArray.PushUInt32((uint)Decoration);
			foreach (var literal in Literals) {
				byteArray.PushInt32(literal);
			}
			return byteArray.ToArray();
		}
	}
}
