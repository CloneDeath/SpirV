using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare the Boolean type. 
	/// Values of this type can only be either true or false. 
	/// There is no physical size or bit pattern defined for these values.
	/// If they are stored (in conjunction with OpVariable), they can only be used with logical 
	/// addressing operations, not physical, and only with non-externally visible shader Storage Classes:
	/// Workgroup, CrossWorkgroup, Private, and Function.
	/// </summary>
	public class TypeBool : SingleResultInstruction
	{
		protected TypeBool(){}
		protected TypeBool(int resultId) : base(resultId){}

		public override Operation OpCode => Operation.TypeBool;
	}
}
