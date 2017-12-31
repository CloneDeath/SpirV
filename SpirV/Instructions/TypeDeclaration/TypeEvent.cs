using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare an OpenCL event type.
	/// </summary>
	public class TypeEvent : SingleResultInstruction
	{
		public override Operation OpCode => Operation.TypeEvent;
	}
}
