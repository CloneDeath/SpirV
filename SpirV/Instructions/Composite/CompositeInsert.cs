using SpirV.Native;

namespace SpirV.Instructions.Composite
{
	/// <summary>
	/// Make a copy of a composite object, while modifying one part of it.
	/// </summary>
	public class CompositeInsert : BaseInstruction {
		public override int WordCount => 5 + Indexes.Length;
		public override Operation OpCode => Operation.CompositeInsert;
		
		/// <summary>
		/// Result Type must be the same type as Composite.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Object is the object to use as the modified part.
		/// </summary>
		public int ObjectId { get; set; }
		
		/// <summary>
		/// Composite is the composite to copy all but the modified part from.
		/// </summary>
		public int CompositeId { get; set; }
		
		/// <summary>
		/// Indexes walk the type hierarchy of Composite to the desired depth,
		/// potentially down to component granularity, to select the part to modify.
		/// All indexes must be in bounds.
		/// All composite constituents use zero-based numbering, as described by their OpType… instruction.
		/// The type of the part selected to modify must match the type of Object.
		/// </summary>
		public int[] Indexes { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(ObjectId);
			ba.PushUInt32(CompositeId);
			ba.PushUInt32(Indexes);
			return ba.ToArray();
		}
	}
}
