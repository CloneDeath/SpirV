using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	/// <summary>
	/// Floating-point subtract of Operand from zero.
	/// 
	/// Result Type must be a scalar or vector of floating-point type.
	/// 
	/// The type of Operand must be the same as Result Type.
	/// 
	/// Results are computed per component.
	/// </summary>
	public class FNegate : SingleResultInstruction {
		public override Operation OpCode => Operation.FNegate;
	}
}
