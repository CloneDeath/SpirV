using SpirV.Instructions.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	/// <summary>
	/// Dot product of Vector 1 and Vector 2.
	/// 
	/// Result Type must be a floating-point type scalar.
	/// 
	/// Vector 1 and Vector 2 must be vectors of the same type, and their component type must be Result Type.
	/// </summary>
	public class Dot : TwoOperandInstruction {
		public override Operation OpCode => Operation.Dot;
	}
}
