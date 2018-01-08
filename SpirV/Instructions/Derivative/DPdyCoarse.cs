﻿using SpirV.Instructions.Derivative.Common;
using SpirV.Native;

namespace SpirV.Instructions.Derivative
{
	/// <summary>
	/// Result is the partial derivative of P with respect to the window y coordinate.
	/// Will use local differencing based on the value of P for the current fragment’s neighbors,
	/// and will possibly, but not necessarily, include the value of P for the current fragment.
	/// That is, over a given area, the implementation can compute y derivatives in fewer unique
	/// locations than would be allowed for OpDPdyFine.
	/// </summary>
	public class DPdyCoarse : DerivativeInstruction
	{
		public override Operation OpCode => Operation.DPdyCoarse;
	}
}
