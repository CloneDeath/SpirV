using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Query the dimensions of Image, with no level of detail.
	/// </summary>
	public class ImageQuerySize : BaseInstruction
	{
		public override int WordCount => 4;
		public override Operation OpCode => Operation.ImageQuerySize;
		
		/// <summary>
		/// Result Type must be an integer type scalar or vector. The number of components must be
		/// 1 for Buffer Dim,
		/// 2 for 2D and Rect Dimensionalities,
		/// 3 for 3D Dim,
		/// plus 1 more if the image type is arrayed.
		/// This vector is filled in with (width [, height] [, elements]) where elements is the
		/// number of layers in an image array.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Image must be an object whose type is OpTypeImage.
		/// Its Dim operand must be one of Rect or Buffer, or if its MS is 1, it can be 2D, or,
		/// if its Sampled Type is 0 or 2, it can be 2D or 3D.
		/// It cannot be an image with level of detail; there is no implicit
		/// level-of-detail consumed by this instruction.
		/// See OpImageQuerySizeLod for querying images having level of detail.
		/// </summary>
		public int ImageId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32((uint) ResultTypeId);
			ba.PushUInt32((uint) ResultId);
			ba.PushUInt32((uint) ImageId);
			return ba.ToArray();
		}
	}
}
