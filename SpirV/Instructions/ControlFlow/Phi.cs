using System;
using SpirV.Native;

namespace SpirV.Instructions.ControlFlow
{
	/// <summary>
	/// The SSA phi function.
	/// 
	/// Within a block, this instruction must appear before all non-OpPhi instructions (except for OpLine,
	/// which can be mixed with OpPhi).
	/// </summary>
	public class Phi : BaseInstruction {
		public override int WordCount => 3 + VariableParentIds.Length;
		public override Operation OpCode => Operation.Phi;
		
		/// <summary>
		/// Result Type can be any type.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		/// <summary>
		/// The result is selected based on control flow:
		/// If control reached the current block from Parent i,
		/// Result Id gets the value that Variable i had at the end of Parent i.
		/// </summary>
		public int ResultId { get; set; }
		
		/// <summary>
		/// Operands are a sequence of pairs:
		/// (Variable 1, Parent 1 block), (Variable 2, Parent 2 block), …
		/// Each Parent i block is the label of an immediate predecessor in the CFG of the current block.
		/// There must be exactly one Parent i for each parent block of the current block in the CFG.
		/// All Variables must have a type matching Result Type.
		/// </summary>
		public int[] VariableParentIds { get; set; } = Array.Empty<int>();
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(VariableParentIds);
			return ba.ToArray();
		}
	}
}
