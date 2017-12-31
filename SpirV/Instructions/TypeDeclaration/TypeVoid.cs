using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare the void type.
	/// </summary>
	public class TypeVoid : SingleResultInstruction
	{
		public TypeVoid(){}
		public TypeVoid(int resultId) : base(resultId){}

		public override Operation OpCode => Operation.TypeVoid;
	}
}
