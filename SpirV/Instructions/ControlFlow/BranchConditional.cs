using System;
using SpirV.Native;

namespace SpirV.Instructions.ControlFlow
{
	/// <summary>
	/// If Condition is true, branch to True Label, otherwise branch to False Label.
	/// 
	/// This instruction must be the last instruction in a block.
	/// </summary>
	public class BranchConditional : BaseInstruction {
		public override int WordCount => 4 + BranchWeights.Length;
		public override Operation OpCode => Operation.BranchConditional;
		
		/// <summary>
		/// Condition must be a Boolean type scalar.
		/// </summary>
		public int ConditionId { get; set; }
		
		/// <summary>
		/// True Label must be an OpLabel in the current function.
		/// </summary>
		public int TrueLabelId { get; set; }
		
		/// <summary>
		/// False Label must be an OpLabel in the current function.
		/// </summary>
		public int FalseLabelId { get; set; }

		/// <summary>
		/// Branch weights are unsigned 32-bit integer literals.
		/// There must be either no Branch Weights or exactly two branch weights.
		/// If present, the first is the weight for branching to True Label,
		/// and the second is the weight for branching to False Label.
		/// The implied probability that a branch is taken is its weight divided by the
		/// sum of the two Branch weights.
		/// </summary>
		public int[] BranchWeights { get; set; } = Array.Empty<int>();
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ConditionId);
			ba.PushUInt32(TrueLabelId);
			ba.PushUInt32(FalseLabelId);
			ba.PushUInt32(BranchWeights);
			return ba.ToArray();
		}
	}
}
