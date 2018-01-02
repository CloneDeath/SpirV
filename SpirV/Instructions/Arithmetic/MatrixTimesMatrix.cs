using SpirV.Instructions.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	/// <summary>
	/// Linear-algebraic multiply of LeftMatrix X RightMatrix. (Operand1 X Operand2)
	/// 
	/// Result Type must be an OpTypeMatrix whose Column Type is a vector of floating-point type.
	/// 
	/// LeftMatrix must be a matrix whose Column Type is the same as the Column Type in Result Type.
	/// 
	/// RightMatrix must be a matrix with the same Component Type as the Component Type in Result Type.
	/// Its number of columns must equal the number of columns in Result Type.
	/// Its columns must have the same number of components as the number of columns in LeftMatrix.
	/// </summary>
	public class MatrixTimesMatrix : TwoOperandInstruction {
		public override Operation OpCode => Operation.MatrixTimesMatrix;
	}
}
