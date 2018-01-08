using SpirV.Instructions.Logical.InstructionTypes;
using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Result is true if any component of Vector is true, otherwise result is f
	/// </summary>
	public class Any : AggregateBooleanVectorInstruction {
		public override Operation OpCode => Operation.Any;
	}
}
