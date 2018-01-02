using SpirV.Native;

namespace SpirV.Instructions.Memory
{
	/// <summary>
	/// Has the same semantics as OpAccessChain, with the addition of the Element operand.
	/// </summary>
	public class PtrAccessChain : BaseInstruction
	{
		public PtrAccessChain(int resultTypeId, int resultId, int baseId, int elementId, params int[] indexIds) {
			ResultTypeId = resultTypeId;
			ResultId = resultId;
			BaseId = baseId;
			ElementId = elementId;
			IndexIds = indexIds;
		}

		public override int WordCount => 5 + IndexIds.Length;
		public override Operation OpCode => Operation.PtrAccessChain;

		/// <summary>
		/// Result Type must be an OpTypePointer. Its Type operand must be the type reached 
		/// by walking the Base’s type hierarchy down to the last provided index in Indexes, 
		/// and its Storage Class operand must be the same as the Storage Class of Base.
		/// </summary>
		public int ResultTypeId { get; set; }

		public int ResultId { get; set; }

		/// <summary>
		/// Base must be a pointer, pointing to the base of a composite object.
		/// Note: If Base is originally typed to be a pointer an array,
		/// and the desired operation is to select an element of that array,
		/// OpAccessChain should be directly used, as its first Index will select the array element.
		/// </summary>
		public int BaseId { get; set; }
		
		/// <summary>
		/// Element is used to do the initial dereference of Base:
		/// Base is treated as the address of the first element of an array,
		/// and the Element element’s address is computed to be the base for the Indexes, as per OpAccessChain.
		/// The type of Base after being dereferenced with Element is still the same as the original type of Base.
		/// </summary>
		public int ElementId { get; set; }

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
			byteArray.PushUInt32((uint) ResultTypeId);
			byteArray.PushUInt32((uint) ResultId);
			byteArray.PushUInt32((uint) BaseId);
			byteArray.PushUInt32((uint) ElementId);
			foreach (var indexId in IndexIds) {
				byteArray.PushUInt32((uint) indexId);
			}
			return byteArray.ToArray();
		}
	}
}
