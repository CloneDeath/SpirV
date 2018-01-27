using SpirV.Native;

namespace SpirV.Instructions.ControlFlow
{
	/// <summary>
	/// Multi-way branch to one of the operand labelid
	/// 
	/// This instruction must be the last instruction in a block.
	/// </summary>
	public class Switch : BaseInstruction {
		public override int WordCount => 3 + TargetIds.Length;
		public override Operation OpCode => Operation.Switch;
		
		/// <summary>
		/// Selector must have a type of OpTypeInt.
		/// Selector will be compared for equality to the Target literals.
		/// </summary>
		public int SelectorId { get; set; }
		
		/// <summary>
		/// Default must be the id of a label.
		/// If Selector does not equal any of the Target literals,
		/// control flow will branch to the Default label id.
		/// </summary>
		public int DefaultId { get; set; }
		
		/// <summary>
		/// Target must be alternating scalar integer literals and the id of a label.
		/// If Selector equals a literal, control flow will branch to the following label id.
		/// It is invalid for any two literal to be equal to each other.
		/// If Selector does not equal any literal, control flow will branch to the Default label id.
		/// Each literal is interpreted with the type of Selector:
		/// The bit width of Selector’s type will be the width of each literal’s type.
		/// If this width is not a multiple of 32-bits,
		/// the literals must be sign extended when the OpTypeInt Signedness is set to 1. (See Literal Number.)
		/// </summary>
		public int[] TargetIds { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(SelectorId);
			ba.PushUInt32(DefaultId);
			ba.PushUInt32(TargetIds);
			return ba.ToArray();
		}
	}
}
