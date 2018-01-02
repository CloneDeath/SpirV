using SpirV.Instructions.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Bit
{
	/// <summary>
	/// Result is 1 if either Operand 1 or Operand 2 is 1. Result is 0 if both Operand 1 and Operand 2 are 0.
	/// 
	/// Results are computed per component, and within each component, per bit.
	/// 
	/// Result Type must be a scalar or vector of integer type.
	/// The type of Operand 1 and Operand 2 must be a scalar or vector of integer type.
	/// They must have the same number of components as Result Type.
	/// They must have the same component width as Result Type.
	/// </summary>
	public class BitwiseOr : TwoOperandInstruction {
		public override Operation OpCode => Operation.BitwiseOr;
	}
}
