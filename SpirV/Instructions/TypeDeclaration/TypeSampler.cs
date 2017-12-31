using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare the sampler type. Consumed by OpSampledImage. This 
	/// type is opaque: values of this type have no defined physical size or
	/// bit pattern.
	/// </summary>
	public class TypeSampler : SingleResultInstruction
	{
		public override Operation OpCode => Operation.TypeSampler;
	}
}
