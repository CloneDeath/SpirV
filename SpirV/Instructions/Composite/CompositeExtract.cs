using System;
using SpirV.Native;

namespace SpirV.Instructions.Composite
{
	/// <summary>
	/// Extract a part of a composite object. 
	/// </summary>
	public class CompositeExtract : BaseInstruction {
		public override int WordCount => 4 + Indexes.Length;
		public override Operation OpCode => Operation.CompositeExtract;
		
		/// <summary>
		/// Result Type must be the type of object selected by the last provided index.
		/// The instruction result is the extracted object.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Composite is the composite to extract from.
		/// </summary>
		public int CompositeId { get; set; }

		/// <summary>
		/// Indexes walk the type hierarchy, potentially down to component granularity, to select the part to extract.
		/// All indexes must be in bounds.
		/// All composite constituents use zero-based numbering, as described by their OpType… instruction.
		/// </summary>
		public int[] Indexes { get; set; } = Array.Empty<int>();
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(CompositeId);
			ba.PushUInt32(Indexes);
			return ba.ToArray();
		}
	}
}
