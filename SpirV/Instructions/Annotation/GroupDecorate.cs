using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.Annotation
{
	/// <summary>
	/// Add a group of Decorations to another id.
	/// </summary>
	public class GroupDecorate : BaseInstruction
	{
		public GroupDecorate() : this(0) { }
		public GroupDecorate(int decorationGroup, params int[] targetIds) {
			DecorationGroup = decorationGroup;
			TargetIds = targetIds;
		}

		public override int WordCount => 2 + TargetIds.Length;
		public override Operation OpCode => Operation.GroupDecorate;

		/// <summary>
		/// Decoration Group is the id of an OpDecorationGroup instruction.
		/// </summary>
		public int DecorationGroup { get; set; }

		/// <summary>
		/// Targets is a list of ids to decorate with the groups of decorations.
		/// </summary>
		public int[] TargetIds { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)DecorationGroup);
			foreach (var targetId in TargetIds) {
				byteArray.PushUInt32((uint)targetId);
			}
			return byteArray.ToArray();
		}
	}
}
