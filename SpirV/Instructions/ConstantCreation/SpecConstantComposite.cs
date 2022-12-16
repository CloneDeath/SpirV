using System;
using SpirV.Native;

namespace SpirV.Instructions.ConstantCreation
{
	/// <summary>
	/// Declare a new composite specialization constant.
	/// This instruction will be specialized to an OpConstantComposite instruction.
	/// </summary>
	public class SpecConstantComposite : BaseInstruction {
		public override int WordCount => 3 + ConstituentIds.Length;
		public override Operation OpCode => Operation.SpecConstantComposite;
		
		/// <summary>
		/// Result Type must be a composite type,
		/// whose top-level members/elements/components/columns have the same type as the types of the Constituents.
		/// The ordering must be the same between the top-level types in Result Type and the Constituents.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Constituents will become members of a structure, or elements of an array, or components of a vector,
		/// or columns of a matrix.
		/// There must be exactly one Constituent for each top-level member/element/component/column of the result.
		/// The Constituents must appear in the order needed by the definition of the type of the result.
		/// The Constituents must be the &lt;id&gt; of other specialization constant or constant declarations.
		/// </summary>
		public int[] ConstituentIds { get; set; } = Array.Empty<int>();
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint) ResultTypeId);
			byteArray.PushUInt32((uint) ResultId);
			foreach (var value in ConstituentIds) {
				byteArray.PushUInt32((uint) value);
			}
			return byteArray.ToArray();
		}
	}
}
