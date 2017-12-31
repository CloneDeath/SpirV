using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.ConstantCreation
{
	/// <summary>
	/// Declare a true Boolean-type scalar constant.
	/// </summary>
	public class ConstantTrue : BaseInstruction
	{
		public override int WordCount => 3;
		public override Operation OpCode => Operation.ConstantTrue;

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
