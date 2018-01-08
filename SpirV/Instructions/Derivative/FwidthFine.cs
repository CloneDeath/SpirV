using SpirV.Instructions.Derivative.Common;
using SpirV.Native;

namespace SpirV.Instructions.Derivative
{
	/// <summary>
	/// Result is the same as computing the sum of the absolute values of OpDPdxFine and OpDPdyFine on P.
	/// </summary>
	public class FwidthFine : DerivativeInstruction
	{
		public override Operation OpCode => Operation.FwidthFine;
	}
}
