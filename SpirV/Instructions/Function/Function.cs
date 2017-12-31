using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.Function
{
	/// <summary>
	/// Add a function. This instruction must be immediately followed by one OpFunctionParameter instruction per each
	/// formal parameter of this function.This function’s body or declaration will terminate with the next OpFunctionEnd
	/// instruction.
	/// </summary>
	public class Function : BaseInstruction
	{
		public Function(int resultTypeId, int resultId, FunctionControl functionControl, int functionTypeId) {
			ResultTypeId = resultTypeId;
			ResultId = resultId;
			FunctionControl = functionControl;
			FunctionTypeId = functionTypeId;
		}

		public override int WordCount => 5;
		public override Operation OpCode => Operation.Function;

		/// <summary>
		/// Result Type must be the same as the Return Type declared in Function Type.
		/// </summary>
		public int ResultTypeId { get; set; }

		/// <summary>
		/// The Result id cannot be used generally by other instructions.
		/// It can only be used by OpFunctionCall, OpEntryPoint, and decoration instructions.
		/// </summary>
		public int ResultId { get; set; }
		public FunctionControl FunctionControl { get; set; }

		/// <summary>
		/// Function Type is the result of an OpTypeFunction, 
		/// which declares the types of the return value and parameters of the function.
		/// </summary>
		public int FunctionTypeId { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultTypeId);
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushUInt32((uint)FunctionControl);
			byteArray.PushUInt32((uint)FunctionTypeId);
			return byteArray.ToArray();
		}
	}
}
