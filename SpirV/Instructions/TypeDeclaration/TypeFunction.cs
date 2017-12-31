using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare a new function type.
	/// 
	/// OpFunction will use this to declare the return type and parameter types of a function.
	/// OpFunction is the only valid use of OpTypeFunction.
	/// </summary>
	public class TypeFunction : BaseInstruction
	{
		public TypeFunction(int resultId, int returnTypeId, params int[] parameterTypeIds) {
			ResultId = resultId;
			ReturnTypeId = returnTypeId;
			ParameterTypeIds = parameterTypeIds;
		}

		public override int WordCount => 3 + ParameterTypeIds.Length;
		public override Operation OpCode => Operation.TypeFunction;

		public int ResultId { get; set; }

		/// <summary>
		/// Return Type is the type of the return value of functions of this type.
		/// It must be a concrete or abstract type, or a pointer to such a type.
		/// If the function has no return value, Return Type must be OpTypeVoid.
		/// </summary>
		public int ReturnTypeId { get; set; }

		/// <summary>
		/// Parameter N Type is the type id of the type of parameter N.
		/// </summary>
		public int[] ParameterTypeIds { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushUInt32((uint)ReturnTypeId);
			foreach (var parameterTypeId in ParameterTypeIds) {
				byteArray.PushUInt32((uint)parameterTypeId);
			}
			return byteArray.ToArray();
		}
	}
}
