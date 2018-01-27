using SpirV.Native;

namespace SpirV.Instructions.ControlFlow
{
	/// <summary>
	/// Unconditional branch to Target Label.
	/// </summary>
	public class Branch : BaseInstruction {
		public override int WordCount => 2;
		public override Operation OpCode => Operation.Branch;
		
		/// <summary>
		/// Target Label must be the ResultId of an OpLabel instruction in the current function.
		/// </summary>
		public int TargetLabelId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(TargetLabelId);
			return ba.ToArray();
		}
	}
}
