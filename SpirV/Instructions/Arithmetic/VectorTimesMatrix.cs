using SpirV.Instructions.Arithmetic.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	/// <summary>
	/// Linear-algebraic Vector X Matrix.
	/// 
	/// Result Type must be a vector of floating-point type.
	/// 
	/// Vector must be a vector with the same Component Type as the Component Type in Result Type.
	/// 
	/// Its number of components must equal the number of components in each column in Matrix.
	/// 
	/// Matrix must be a matrix with the same Component Type as the Component Type in Result Type.
	/// Its number of columns must equal the number of components in Result Type.
	/// </summary>
	public class VectorTimesMatrix : TwoOperandInstruction {
		public override Operation OpCode => Operation.VectorTimesMatrix;
	}
}
