using SpirV.Native;

namespace SpirV.Instructions.ConstantCreation
{
	/// <summary>
	/// Declare a false Boolean-type scalar constant.
	/// </summary>
	public class ConstantFalse : BaseInstruction
	{
		public override int WordCount => 3;
		public override Operation OpCode => Operation.ConstantFalse;

		/// <summary>
		/// Result Type must be the scalar Boolean type.
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
