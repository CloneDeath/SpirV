using SpirV.Instructions.Arithmetic.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	// ReSharper disable once InconsistentNaming
	/// <summary>
	/// Result is the unsigned integer addition of Operand 1 and Operand 2, including its carry.
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
	/// Member 0 of the result gets the low-order bits (full component width) of the addition.
	/// 
	/// Member 1 of the result gets the high-order (carry) bit of the result of the addition.
	/// That is, it gets the value 1 if the addition overflowed the component width, and 0 otherwise.
	/// </summary>
	public class IAddCarry : TwoOperandInstruction {
		public override Operation OpCode => Operation.IAddCarry;
	}
}
