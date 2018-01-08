using SpirV.Instructions.Derivative.Common;
using SpirV.Native;

namespace SpirV.Instructions.Derivative
{
	/// <summary>
	/// Same result as either OpDPdyFine or OpDPdyCoarse on P.
	/// Selection of which one is based on external factors.
	/// </summary>
	public class DPdy : DerivativeInstruction
	{
		public override Operation OpCode => Operation.DPdy;
	}
}
