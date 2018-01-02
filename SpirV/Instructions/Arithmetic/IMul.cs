using SpirV.Instructions.Arithmetic.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	// ReSharper disable once InconsistentNaming
	/// <summary>
	/// Integer multiplication of Operand 1 and Operand 2.
	/// 
	/// Result Type must be a scalar or vector of integer type.
	/// 
	/// The type of Operand 1 and Operand 2 must be a scalar or vector of integer type.
	/// They must have the same number of components as Result Type.
	/// They must have the same component width as Result Type.
	/// 
	/// Results are computed per component.
	/// </summary>
	public class IMul : TwoOperandInstruction {
		public override Operation OpCode => Operation.IMul;
	}
}
