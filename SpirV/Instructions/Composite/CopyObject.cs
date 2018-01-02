using SpirV.Native;

namespace SpirV.Instructions.Composite
{
	/// <summary>
	/// Make a copy of Operand.
	/// There are no dereferences involved.
	/// </summary>
	public class CopyObject : BaseInstruction {
		public override int WordCount => 4;
		public override Operation OpCode => Operation.CopyObject;
		
		/// <summary>
		/// Result Type must match Operand type.
		/// There are no other restrictions on the types.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		public int OperandId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(OperandId);
			return ba.ToArray();
		}
	}
}
