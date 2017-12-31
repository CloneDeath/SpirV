using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare an OpenCL reservation id type.
	/// </summary>
	public class TypeReserveId : SingleResultInstruction
	{
		public override Operation OpCode => Operation.TypeReserveId;
	}
}
