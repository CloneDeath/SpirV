using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare an OpenCL device-side event type.
	/// </summary>
	public class TypeDeviceEvent : SingleResultInstruction
	{
		public TypeDeviceEvent() {}
		public TypeDeviceEvent(int resultId) : base(resultId) {}
		
		public override Operation OpCode => Operation.TypeDeviceEvent;
	}
}
