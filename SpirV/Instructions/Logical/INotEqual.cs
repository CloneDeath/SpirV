using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	// ReSharper disable once InconsistentNaming
	/// <summary>
	/// Integer comparison for inequality.
	/// </summary>
	public class INotEqual : IntegerBinaryInstruction {
		public override Operation OpCode => Operation.INotEqual;
	}
}
