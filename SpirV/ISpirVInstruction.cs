using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV
{
	public interface ISpirVInstruction
	{
		int WordCount { get; }
		Operation OpCode { get; }

		byte[] GetBytes();
	}
}