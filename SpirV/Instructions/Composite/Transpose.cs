using SpirV.Native;

namespace SpirV.Instructions.Composite
{
	/// <summary>
	/// Transpose a matrix.
	/// </summary>
	public class Transpose : BaseInstruction {
		public override int WordCount => 4;
		public override Operation OpCode => Operation.Transpose;
		
		/// <summary>
		/// Result Type must be an OpTypeMatrix, where the number of columns and the column size is the reverse of
		/// those of the type of Matrix.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Matrix must have of type of OpTypeMatrix.
		/// </summary>
		public int MatrixId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(MatrixId);
			return ba.ToArray();
		}
	}
}
