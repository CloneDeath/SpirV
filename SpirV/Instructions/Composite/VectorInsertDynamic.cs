using SpirV.Native;

namespace SpirV.Instructions.Composite
{
	/// <summary>
	/// Make a copy of a vector, with a single, variably selected, component modified.
	/// </summary>
	public class VectorInsertDynamic : BaseInstruction {
		public override int WordCount => 6;
		public override Operation OpCode => Operation.VectorInsertDynamic;
		
		/// <summary>
		/// Result Type must be an OpTypeVector.
		/// </summary>
		public int ResultyTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Vector must have the same type as Result Type and is the vector that the non-written components will
		/// be copied from.
		/// </summary>
		public int VectorId { get; set; }
		
		/// <summary>
		/// Component is the value that will be supplied for the component selected by Index.
		/// It must have the same type as the type of components in Result Type.
		/// </summary>
		public int ComponentId { get; set; }
		
		/// <summary>
		/// Index must be a scalar integer 0-based index of which component to modify.
		/// 
		/// What is written is undefined if Index’s value is less than zero or greater than or equal to the number
		/// of components in Vector.
		/// </summary>
		public int IndexId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultyTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(VectorId);
			ba.PushUInt32(ComponentId);
			ba.PushUInt32(IndexId);
			return ba.ToArray();
		}
	}
}
