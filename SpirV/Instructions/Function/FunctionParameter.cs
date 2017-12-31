using SpirV.Native;

namespace SpirV.Instructions.Function
{
	/// <summary>
	/// Declare a formal parameter of the current function.
	/// 
	/// This instruction must immediately follow an OpFunction or OpFunctionParameter instruction. 
	/// The order of contiguous OpFunctionParameter instructions is the same order arguments will 
	/// be listed in an OpFunctionCall instruction to this function. It is also the same order in 
	/// which Parameter Type operands are listed in the OpTypeFunction of the Function Type 
	/// operand for this function’s OpFunction instruction.
	/// </summary>
	public class FunctionParameter : BaseInstruction
	{
		public override int WordCount => 3;
		public override Operation OpCode => Operation.FunctionParameter;

		/// <summary>
		/// Result Type is the type of the parameter.
		/// </summary>
		public int ResultTypeId { get; set; }
		public int ResultId { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultTypeId);
			byteArray.PushUInt32((uint)ResultId);
			return byteArray.ToArray();
		}
	}
}
