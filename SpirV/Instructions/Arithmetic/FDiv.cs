﻿using SpirV.Instructions.SubTypes;
using SpirV.Native;

namespace SpirV.Instructions.Arithmetic
{
	/// <summary>
	/// Floating-point division of Operand 1 divided by Operand 2.
	/// 
	/// Result Type must be a scalar or vector of floating-point type.
	/// 
	/// The types of Operand 1 and Operand 2 both must be the same as Result Type.
	/// 
	/// Results are computed per component. The resulting value is undefined if Operand 2 is 0.
	/// </summary>
	public class FDiv : TwoOperandInstruction {
		public override Operation OpCode => Operation.FDiv;
	}
}
