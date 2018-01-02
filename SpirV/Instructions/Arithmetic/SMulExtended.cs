using SpirV.Instructions.Arithmetic.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	/// <summary>
	/// Result is the full value of the signed integer multiplication of Operand 1 and Operand 2.
	/// 
	/// Result Type must be from OpTypeStruct.
	/// The struct must have two members, and the two members must be the same type.
	/// The member type must be a scalar or vector of integer type.
	/// 
	/// Operand 1 and Operand 2 must have the same type as the members of Result Type.
	/// These are consumed as signed integers.
	/// 
	/// Results are computed per component.
	/// 
	/// Member 0 of the result gets the low-order bits of the multiplication.
	/// 
	/// Member 1 of the result gets the high-order bits of the multiplication.
	/// </summary>
	public class SMulExtended : TwoOperandInstruction {
		public override Operation OpCode => Operation.SMulExtended;
	}
}
