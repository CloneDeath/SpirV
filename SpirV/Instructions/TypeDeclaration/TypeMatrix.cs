using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare a new matrix type.
	/// Matrix columns are numbered consecutively, starting with 0. This is true 
	/// independently of any Decorations describing the memory layout of a matrix(e.g.,
	/// RowMajor or MatrixStride).
	/// </summary>
	public class TypeMatrix : BaseInstruction
	{
		public override int WordCount => 4;
		public override Operation OpCode => Operation.TypeMatrix;

		public int ResultId { get; set; }

		/// <summary>
		/// Column Type is the type of each column in the matrix.It must be vector type.
		/// </summary>
		public int ColumnType { get; set; }

		/// <summary>
		/// Column Count is the number of columns in the new matrix type.It must be at least 2.
		/// </summary>
		public int ColumnCount { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushUInt32((uint)ColumnType);
			byteArray.PushUInt32((uint)ColumnCount);
			return byteArray.ToArray();
		}
	}
}
