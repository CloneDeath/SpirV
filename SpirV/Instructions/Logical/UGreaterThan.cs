﻿using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Unsigned-integer comparison if Operand 1 is greater than Operand 2.
	/// </summary>
	public class UGreaterThan : IntegerBinaryInstruction {
		public override Operation OpCode => Operation.UGreaterThan;
	}
}
