using SpirV.Instructions.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	/// <summary>
	/// Signed modulo operation of Operand 1 modulo Operand 2.
	/// The sign of a non-0 result comes from Operand 2.
	/// 
	/// Result Type must be a scalar or vector of integer type.
	/// 
	/// The type of Operand 1 and Operand 2 must be a scalar or vector of integer type.
	/// They must have the same number of components as Result Type.
	/// They must have the same component width as Result Type.
	/// 
	/// Results are computed per component.
	/// The resulting value is undefined if Operand 2 is 0.
	/// </summary>
	public class SMod : TwoOperandInstruction {
		public override Operation OpCode => Operation.SMod;
	}
}
