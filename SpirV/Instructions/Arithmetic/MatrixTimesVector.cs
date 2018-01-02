using SpirV.Instructions.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	/// <summary>
	/// Linear-algebraic Vector X Matrix.
	/// 
	/// Result Type must be a vector of floating-point type.
	/// 
	/// Matrix must be an OpTypeMatrix whose Column Type is Result Type.
	/// 
	/// Vector must be a vector with the same Component Type as the Component Type in Result Type.
	/// Its number of components must equal the number of columns in Matrix.
	/// </summary>
	public class MatrixTimesVector : TwoOperandInstruction {
		public override Operation OpCode => Operation.MatrixTimesVector;
	}
}
