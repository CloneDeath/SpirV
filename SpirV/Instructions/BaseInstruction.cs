using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions
{
	public abstract class BaseInstruction : ISpirVInstruction
	{
		public abstract int WordCount { get; }
		public abstract Operation OpCode { get; }

		public byte[] GetBytes() {
			var bytes = new ByteArray();
			bytes.PushUInt16((ushort)OpCode);
			bytes.PushUInt16((ushort)WordCount);

			bytes.Push(GetParameterBytes());

			return bytes.ToArray();
		}

		protected abstract byte[] GetParameterBytes();
	}
}
