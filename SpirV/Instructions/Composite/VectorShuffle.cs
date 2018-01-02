using SpirV.Native;

namespace SpirV.Instructions.Composite
{
	/// <summary>
	/// Select arbitrary components from two vectors to make a new vector.
	/// 
	/// Note: A vector “swizzle” can be done by using the vector for both Vector operands,
	/// or using an OpUndef for one of the Vector operands.
	/// </summary>
	public class VectorShuffle : BaseInstruction {
		public override int WordCount => 5 + Components.Length;
		public override Operation OpCode => Operation.VectorShuffle;
		
		/// <summary>
		/// Result Type must be an OpTypeVector.
		/// The number of components in Result Type must be the same as the number of Component operands.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Vector 1 and Vector 2 must both have vector types, with the same Component Type as Result Type.
		/// They do not have to have the same number of components as Result Type or with each other.
		/// They are logically concatenated, forming a single vector with Vector 1’s components appearing
		/// before Vector 2’s.
		/// The components of this logical vector are logically numbered with a single consecutive set of numbers
		/// from 0 to N - 1, where N is the total number of components.
		/// </summary>
		public int Vector1Id { get; set; }
		
		/// <summary>
		/// Vector 1 and Vector 2 must both have vector types, with the same Component Type as Result Type.
		/// They do not have to have the same number of components as Result Type or with each other.
		/// They are logically concatenated, forming a single vector with Vector 1’s components appearing
		/// before Vector 2’s.
		/// The components of this logical vector are logically numbered with a single consecutive set of numbers
		/// from 0 to N - 1, where N is the total number of components.
		/// </summary>
		public int Vector2Id { get; set; }
		
		/// <summary>
		/// Components are these logical numbers (see above), selecting which of the logically numbered components
		/// form the result.
		/// They can select the components in any order and can repeat components.
		/// The first component of the result is selected by the first Component operand,
		/// the second component of the result is selected by the second Component operand, etc.
		/// A Component literal may also be FFFFFFFF, which means the corresponding result component has no
		/// source and is undefined.
		/// All Component literals must either be FFFFFFFF or in [0, N - 1] (inclusive).
		/// </summary>
		public uint[] Components { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(Vector1Id);
			ba.PushUInt32(Vector2Id);
			ba.PushUInt32(Components);
			return ba.ToArray();
		}
	}
}
