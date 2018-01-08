using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Result is true if all components of Vector are true, otherwise result is false.
	/// </summary>
	public class All : AggregateBooleanVectorInstruction {
		public override Operation OpCode => Operation.All;
	}
}
