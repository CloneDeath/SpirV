using SpirV.Native;

namespace SpirV.Instructions.ConstantCreation
{
	/// <summary>
	/// Declare a Boolean-type scalar specialization constant with a default value of true.
	/// This instruction can be specialized to become either an OpConstantTrue or OpConstantFalse instruction.
	/// </summary>
	public class SpecConstantTrue : BaseInstruction {
		public override int WordCount => 3;
		public override Operation OpCode => Operation.SpecConstantTrue;
		
		/// <summary>
		/// Result Type must be the scalar Boolean type.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint) ResultTypeId);
			byteArray.PushUInt32((uint) ResultId);
			return byteArray.ToArray();
		}
	}
}
