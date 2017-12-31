using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.Memory
{
	/// <summary>
	/// Create a pointer into a composite object that can be used with OpLoad and OpStore.
	/// </summary>
	public class AccessChain : BaseInstruction
	{
		public AccessChain(int resultTypeId, int resultId, int baseId, params int[] indexIds) {
			ResultTypeId = resultTypeId;
			ResultId = resultId;
			BaseId = baseId;
			IndexIds = indexIds;
		}

		public override int WordCount => 4 + IndexIds.Length;
		public override Operation OpCode => Operation.AccessChain;

		/// <summary>
		/// Result Type must be an OpTypePointer. Its Type operand must be the type reached 
		/// by walking the Base’s type hierarchy down to the last provided index in Indexes, 
		/// and its Storage Class operand must be the same as the Storage Class of Base.
		/// </summary>
		public int ResultTypeId { get; set; }

		public int ResultId { get; set; }

		/// <summary>
		/// Base must be a pointer, pointing to the base of a composite object.
		/// </summary>
		public int BaseId { get; set; }

		/// <summary>
		/// Indexes walk the type hierarchy to the desired depth, potentially down to scalar granularity.
		/// The first index in Indexes will select the top-level member/element/component/element of the 
		/// base composite. All composite constituents use zero-based numbering, as described by their
		/// OpType... instruction. The second index will apply similarly to that result, and so on.
		/// Once any non-composite type is reached, there must be no remaining (unused) indexes.
		/// Each of the Indexes must:
		/// - be a scalar integer type,
		/// - be an OpConstant when indexing into a structure.
		/// </summary>
		public int[] IndexIds { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultTypeId);
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushUInt32((uint)BaseId);
			foreach (var indexId in IndexIds) {
				byteArray.PushUInt32((uint)indexId);
			}
			return byteArray.ToArray();
		}
	}
}
