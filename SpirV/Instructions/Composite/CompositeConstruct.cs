using SpirV.Native;

namespace SpirV.Instructions.Composite
{
	/// <summary>
	/// Construct a new composite object from a set of constituent objects that will fully form it.
	/// </summary>
	public class CompositeConstruct : BaseInstruction {
		public override int WordCount => 3 + Constituents.Length;
		public override Operation OpCode => Operation.CompositeConstruct;
		
		/// <summary>
		/// Result Type must be a composite type, whose top-level members/elements/components/columns have the same
		/// type as the types of the operands, with one exception.
		/// The exception is that for constructing a vector, the operands may also be vectors with the same component
		/// type as the Result Type component type.
		/// When constructing a vector, the total number of components in all the operands must equal the number of
		/// components in Result Type.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Constituents will become members of a structure, or elements of an array, or components of a vector,
		/// or columns of a matrix.
		/// There must be exactly one Constituent for each top-level member/element/component/column of the result,
		/// with one exception.
		/// The exception is that for constructing a vector, a contiguous subset of the scalars consumed can be
		/// represented by a vector operand instead.
		/// The Constituents must appear in the order needed by the definition of the type of the result.
		/// When constructing a vector, there must be at least two Constituent operands.
		/// </summary>
		public int[] Constituents { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(Constituents);
			return ba.ToArray();
		}
	}
}
