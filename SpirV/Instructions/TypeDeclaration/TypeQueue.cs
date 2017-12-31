using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare an OpenCL queue type.
	/// </summary>
	public class TypeQueue : SingleResultInstruction
	{
		public override Operation OpCode => Operation.TypeQueue;
	}
}
