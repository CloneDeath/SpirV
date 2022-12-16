using System;
using SpirV.Native;

namespace SpirV.Instructions.Function
{
	/// <summary>
	/// Call a function.
	/// 
	/// Note: A forward call is possible because there is no missing type information:
	/// Result Type must match the Return Type of the function, and the calling 
	/// argument types must match the formal parameter types.
	/// </summary>
	public class FunctionCall : BaseInstruction
	{
		public override int WordCount => 4 + ArgumentIds.Length;
		public override Operation OpCode => Operation.FunctionCall;

		/// <summary>
		/// Result Type is the type of the return value of the function.
		/// It must be the same as the Return Type operand of the Function Type operand of the Function operand.
		/// </summary>
		public int ResultTypeId { get; set; }
		public int ResultId { get; set; }

		/// <summary>
		/// Function is an OpFunction instruction.This could be a forward reference.
		/// </summary>
		public int FunctionId { get; set; }

		/// <summary>
		/// Argument N is the object to copy to parameter N of Function.
		/// </summary>
		public int[] ArgumentIds { get; set; } = Array.Empty<int>();

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultTypeId);
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushUInt32((uint)FunctionId);
			foreach (var argumentId in ArgumentIds) {
				byteArray.PushUInt32((uint)argumentId);
			}
			return byteArray.ToArray();
		}
	}
}
