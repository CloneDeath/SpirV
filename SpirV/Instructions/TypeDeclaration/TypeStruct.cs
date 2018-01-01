using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare a new structure type: an aggregate of potentially heterogeneous members. 
	/// If an operand is not yet defined, it must be defined by an OpTypePointer, 
	/// where the type pointed to is an OpTypeStruct.
	/// </summary>
	public class TypeStruct : BaseInstruction
	{
		public TypeStruct(int resultId, params int[] memberTypeIds) {
			ResultId = resultId;
			MemberTypeIds = memberTypeIds;
		}

		public override int WordCount => 2 + MemberTypeIds.Length;
		public override Operation OpCode => Operation.TypeStruct;

		public int ResultId { get; set; }

		/// <summary>
		/// Member N type is the type of member N of the structure.
		/// The first member is member 0, the next is member 1,...
		/// </summary>
		public int[] MemberTypeIds { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultId);
			foreach (var memberTypeId in MemberTypeIds) {
				byteArray.PushUInt32((uint)memberTypeId);
			}
			return byteArray.ToArray();
		}
	}
}
