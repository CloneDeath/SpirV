using SpirV.Instructions.Derivative.Common;
using SpirV.Native;

namespace SpirV.Instructions.Derivative
{
	/// <summary>
	/// Result is the partial derivative of P with respect to the window y coordinate.
	/// Will use local differencing based on the value of P for the current fragment and its immediate neighbor(s).
	/// </summary>
	public class DPdyFine : DerivativeInstruction
	{
		public override Operation OpCode => Operation.DPdyFine;
	}
}
