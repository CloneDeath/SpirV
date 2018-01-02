using SpirV.Instructions.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	// ReSharper disable once InconsistentNaming
	/// <summary>
	/// Integer addition of Operand 1 and Operand 2.
	/// 
	/// Result Type must be a scalar or vector of integer type.
	/// 
	/// The type of Operand 1 and Operand 2 must be a scalar or vector of integer type.
	/// They must have the same number of components as Result Type.
	/// They must have the same component width as Result Type.
	/// 
	/// Results are computed per component.
	/// </summary>
	public class IAdd : TwoOperandInstruction {
		public override Operation OpCode => Operation.IAdd;
	}
}
