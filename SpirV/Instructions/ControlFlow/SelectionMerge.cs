using SpirV.Native;

namespace SpirV.Instructions.ControlFlow
{
	/// <summary>
	/// Declare a structured selection.
	/// 
	/// This instruction must immediately precede either an OpBranchConditional or OpSwitch instruction.
	/// That is, it must be the second-to-last instruction in its block.
	/// 
	/// See Structured Control Flow for more detail.
	/// https://www.khronos.org/registry/spir-v/specs/1.0/SPIRV.html#StructuredControlFlow
	/// </summary>
	public class SelectionMerge : BaseInstruction {
		public override int WordCount => 3;
		public override Operation OpCode => Operation.SelectionMerge;
		
		/// <summary>
		/// Merge Block is the label of the merge block for this structured selection.
		/// </summary>
		public int MergeBlockId { get; set; }
		public SelectionControlMask SelectionControl { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(MergeBlockId);
			ba.PushUInt32((int)SelectionControl);
			return ba.ToArray();
		}
	}
}
