using SpirV.Instructions.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	/// <summary>
	/// Linear-algebraic outer product of Vector 1 and Vector 2.
	/// 
	/// Result Type must be an OpTypeMatrix whose Column Type is a vector of floating-point type.
	/// 
	/// Vector 1 must have the same type as the Column Type in Result Type.
	/// 
	/// Vector 2 must be a vector with the same Component Type as the Component Type in Result Type.
	/// Its number of components must equal the number of columns in Result Type.
	/// </summary>
	public class OuterProduct : TwoOperandInstruction {
		public override Operation OpCode => Operation.OuterProduct;
	}
}
