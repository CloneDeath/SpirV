using SpirV.Instructions.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	/// <summary>
	/// Signed-integer subtract of Operand from zero.
	/// 
	/// Result Type must be a scalar or vector of integer type.
	/// 
	/// Operand’s type must be a scalar or vector of integer type.
	/// It must have the same number of components as Result Type.
	/// The component width must equal the component width in Result Type.
	/// 
	/// Results are computed per component.
	/// </summary>
	public class SNegate : SingleOperandInstruction {
		public override Operation OpCode => Operation.SNegate;
	}
}
