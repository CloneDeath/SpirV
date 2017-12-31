using SpirV.Native;

namespace SpirV
{
	public interface ISpirVInstruction
	{
		int WordCount { get; }
		Operation OpCode { get; }

		byte[] GetBytes();
	}
}