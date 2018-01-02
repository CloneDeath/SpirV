using SpirV.Instructions.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	/// <summary>
	/// Scale a floating-point matrix.
	/// 
	/// Result Type must be an OpTypeMatrix whose Column Type is a vector of floating-point type.
	/// 
	/// The type of Matrix must be the same as Result Type.
	/// Each component in each column in Matrix is multiplied by Scalar.
	/// 
	/// Scalar must have the same type as the Component Type in Result Type.
	/// </summary>
	public class MatrixTimesScalar : TwoOperandInstruction {
		public override Operation OpCode => Operation.MatrixTimesScalar;
	}
}
