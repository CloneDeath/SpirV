using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare an OpenCL reservation id type.
	/// </summary>
	public class TypeReserveId : SingleResultInstruction
	{
		public override Operation OpCode => Operation.TypeReserveId;
	}
}
