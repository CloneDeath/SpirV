using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	// ReSharper disable once InconsistentNaming
	/// <summary>
	/// Integer comparison for equality.
	/// </summary>
	public class IEqual : IntegerBinaryInstruction {
		public override Operation OpCode => Operation.IEqual;
	}
}
