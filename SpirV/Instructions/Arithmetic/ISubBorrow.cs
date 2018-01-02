using SpirV.Instructions.Arithmetic.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	// ReSharper disable once InconsistentNaming
	/// <summary>
	/// Result is the unsigned integer subtraction of Operand 2 from Operand 1, and what it needed to borrow.
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
	/// Member 0 of the result gets the low-order bits (full component width) of the subtraction.
	/// That is, if Operand 1 is larger than Operand 2, member 0 gets the full value of the subtraction;
	/// if Operand 2 is larger than Operand 1, member 0 gets 2w + Operand 1 - Operand 2, where w is the component width.
	/// 
	/// Member 1 of the result gets 0 if Operand 1 ≥ Operand 2, and gets 1 otherwise.
	/// </summary>
	public class ISubBorrow : TwoOperandInstruction {
		public override Operation OpCode => Operation.ISubBorrow;
	}
}
