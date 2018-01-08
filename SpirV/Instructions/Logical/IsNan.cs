﻿using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Result is true if x is an IEEE NaN, otherwise result is false.
	/// </summary>
	public class IsNan : FloatUnaryInstruction {
		public override Operation OpCode => Operation.IsNan;
	}
}
