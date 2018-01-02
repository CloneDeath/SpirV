using SpirV.Instructions.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	/// <summary>
	/// Scale a floating-point vector.
	/// 
	/// Result Type must be a vector of floating-point type.
	/// 
	/// The type of Vector must be the same as Result Type.
	/// Each component of Vector is multiplied by Scalar.
	/// 
	/// Scalar must have the same type as the Component Type in Result Type.
	/// </summary>
	public class VectorTimesScalar : TwoOperandInstruction {
		public override Operation OpCode => Operation.VectorTimesScalar;
	}
}
