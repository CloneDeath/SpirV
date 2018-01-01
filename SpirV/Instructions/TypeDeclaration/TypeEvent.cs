using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare an OpenCL event type.
	/// </summary>
	public class TypeEvent : SingleResultInstruction
	{
		public TypeEvent() {}
		public TypeEvent(int resultId) : base(resultId) {}
		
		public override Operation OpCode => Operation.TypeEvent;
	}
}
