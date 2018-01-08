using SpirV.Instructions.Derivative.Common;
using SpirV.Native;

namespace SpirV.Instructions.Derivative
{
	/// <summary>
	/// Result is the same as computing the sum of the absolute values of OpDPdx and OpDPdy on P.
	/// </summary>
	public class Fwidth : DerivativeInstruction
	{
		public override Operation OpCode => Operation.Fwidth;
	}
}
