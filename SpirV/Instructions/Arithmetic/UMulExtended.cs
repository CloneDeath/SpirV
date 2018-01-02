using SpirV.Instructions.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	/// <summary>
	/// Result is the full value of the unsigned integer multiplication of Operand 1 and Operand 2.
	/// 
	/// Result Type must be from OpTypeStruct.
	/// The struct must have two members, and the two members must be the same type.
	/// The member type must be a scalar or vector of integer type, whose Signedness operand is 0.
	/// 
	/// Operand 1 and Operand 2 must have the same type as the members of Result Type.
	/// These are consumed as unsigned integers.
	/// 
	/// Results are computed per component.
	/// 
	/// Member 0 of the result gets the low-order bits of the multiplication.
	/// 
	/// Member 1 of the result gets the high-order bits of the multiplication.
	/// </summary>
	public class UMulExtended : TwoOperandInstruction {
		public override Operation OpCode => Operation.UMulExtended;
	}
}
