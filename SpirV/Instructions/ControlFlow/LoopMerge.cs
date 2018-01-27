using SpirV.Native;

namespace SpirV.Instructions.ControlFlow
{
	/// <summary>
	/// Declare a structured loop.
	/// 
	/// This instruction must immediately precede either an OpBranch or OpBranchConditional instruction.
	/// That is, it must be the second-to-last instruction in its block.
	/// 
	/// See Structured Control Flow for more detail.
	/// https://www.khronos.org/registry/spir-v/specs/1.0/SPIRV.html#StructuredControlFlow
	/// </summary>
	public class LoopMerge : BaseInstruction {
		public override int WordCount => 4;
		public override Operation OpCode => Operation.LoopMerge;
		
		/// <summary>
		/// Merge Block is the label of the merge block for this structured loop.
		/// </summary>
		public int MergeBlockId { get; set; }
		
		/// <summary>
		/// Continue Target is the label of a block targeted for processing a loop "continue".
		/// </summary>
		public int ContinueTargetId { get; set; }
		
		public LoopControlMask LoopControl { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(MergeBlockId);
			ba.PushUInt32(ContinueTargetId);
			ba.PushUInt32((int)LoopControl);
			return ba.ToArray();
		}
	}
}
