using SpirV.Instructions.Arithmetic.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	/// <summary>
	/// Floating-point addition of Operand 1 and Operand 2.
	/// 
	/// Result Type must be a scalar or vector of floating-point type.
	/// 
	/// The types of Operand 1 and Operand 2 both must be the same as Result Type.
	/// 
	/// Results are computed per component.
	/// </summary>
	public class FAdd : TwoOperandInstruction {
		public override Operation OpCode => Operation.FAdd;
	}
}
