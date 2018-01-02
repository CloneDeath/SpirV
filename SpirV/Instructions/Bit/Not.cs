using SpirV.Instructions.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Bit
{
	/// <summary>
	/// Complement the bits of Operand.
	/// 
	/// Results are computed per component, and within each component, per bit.
	/// 
	/// Result Type must be a scalar or vector of integer type.
	/// 
	/// Operand’s type must be a scalar or vector of integer type.
	/// It must have the same number of components as Result Type.
	/// The component width must equal the component width in Result Type.
	/// </summary>
	public class Not : SingleOperandInstruction {
		public override Operation OpCode => Operation.Not;
	}
}
