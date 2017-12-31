using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.Annotation
{
	/// <summary>
	/// Add a Decoration to another id.
	/// </summary>
	public class Decorate : BaseInstruction
	{
		public Decorate():this(0, Decoration.Max) { }
		public Decorate(int targetId, Decoration decoration, params int[] literals) {
			TargetId = targetId;
			Decoration = decoration;
			Literals = literals;
		}

		public override int WordCount => 3 + Literals.Length;
		public override Operation OpCode => Operation.Decorate;

		/// <summary>
		/// Target is the id to decorate. It can potentially be any id that is a forward reference.
		/// A set of decorations can be grouped together by having multiple OpDecorate instructions 
		/// target the same OpDecorationGroup instruction.
		/// </summary>
		public int TargetId { get; set; }
		public Decoration Decoration { get; set; }
		public int[] Literals { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)TargetId);
			byteArray.PushUInt32((uint)Decoration);
			foreach (var literal in Literals) {
				byteArray.PushInt32(literal);
			}
			return byteArray.ToArray();
		}
	}
}
