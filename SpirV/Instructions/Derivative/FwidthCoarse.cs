using SpirV.Instructions.Derivative.Common;
using SpirV.Native;

namespace SpirV.Instructions.Derivative
{
	/// <summary>
	/// Result is the same as computing the sum of the absolute values of OpDPdxCoarse and OpDPdyCoarse on P.
	/// </summary>
	public class FwidthCoarse : DerivativeInstruction
	{
		public override Operation OpCode => Operation.FwidthCoarse;
	}
}
