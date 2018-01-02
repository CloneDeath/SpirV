using SpirV.Native;

namespace SpirV.Instructions.Composite
{
	/// <summary>
	/// Extract a single, dynamically selected, component of a vector.
	/// </summary>
	public class VectorExtractDynamic : BaseInstruction {
		public override int WordCount => 5;
		public override Operation OpCode => Operation.VectorExtractDynamic;
		
		/// <summary>
		/// Result Type must be a scalar type.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Vector must have a type OpTypeVector whose Component Type is Result Type.
		/// </summary>
		public int VectorId { get; set; }
		
		/// <summary>
		/// Index must be a scalar integer 0-based index of which component of Vector to extract.
		/// The value read is undefined if Index’s value is less than zero or greater than or equal to the
		/// number of components in Vector.
		/// </summary>
		public int IndexId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(VectorId);
			ba.PushUInt32(IndexId);
			return ba.ToArray();
		}
	}
}
