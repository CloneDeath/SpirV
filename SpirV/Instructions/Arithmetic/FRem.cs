using SpirV.Instructions.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	/// <summary>
	/// Floating-point remainder operation of Operand 1 divided by Operand 2.
	/// The sign of a non-0 result comes from Operand 1.
	/// 
	/// Result Type must be a scalar or vector of floating-point type.
	/// 
	/// The types of Operand 1 and Operand 2 both must be the same as Result Type.
	/// 
	/// Results are computed per component.
	/// The resulting value is undefined if Operand 2 is 0.
	/// </summary>
	public class FRem : TwoOperandInstruction {
		public override Operation OpCode => Operation.FRem;
	}
}
