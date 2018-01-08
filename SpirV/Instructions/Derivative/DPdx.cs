using SpirV.Instructions.Derivative.Common;
using SpirV.Native;

namespace SpirV.Instructions.Derivative
{
	/// <summary>
	/// Same result as either OpDPdxFine or OpDPdxCoarse on P.
	/// Selection of which one is based on external factors.
	/// </summary>
	public class DPdx : DerivativeInstruction {
		public override Operation OpCode => Operation.DPdx;
	}
}
