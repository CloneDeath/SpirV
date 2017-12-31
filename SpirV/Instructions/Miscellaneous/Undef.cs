using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.Miscellaneous
{
	/// <summary>
	/// Make an intermediate object whose value is undefined.
	/// </summary>
	public class Undef : BaseInstruction
	{
		public Undef(int resultType, int resultId) {
			ResultType = resultType;
			ResultId = resultId;
		}

		public override int WordCount => 3;
		public override Operation OpCode => Operation.Undef;

		/// <summary>
		/// Result Type is the type of object to make.
		/// </summary>
		public int ResultType { get; set; }

		/// <summary>
		/// Each consumption of Resultid yields an arbitrary, possibly different bit pattern.
		/// </summary>
		public int ResultId { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultType);
			byteArray.PushUInt32((uint)ResultId);
			return byteArray.ToArray();
		}
	}
}
