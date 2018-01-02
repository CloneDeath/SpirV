using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Query the dimensions of Image for mipmap level for Level of Detail.
	/// </summary>
	public class ImageQuerySizeLod : BaseInstruction {
		public override int WordCount => 5;
		public override Operation OpCode => Operation.ImageQuerySizeLod;
		
		/// <summary>
		/// Result Type must be an integer type scalar or vector. The number of components must be
		/// 1 for 1D Dim,
		/// 2 for 2D, and Cube Dimensionalities,
		/// 3 for 3D Dim,
		/// plus 1 more if the image type is arrayed. This vector is filled in with (width [, height] [, depth] [, elements]) where elements is the number of layers in an image array, or the number of cubes in a cube-map array.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Image must be an object whose type is OpTypeImage.
		/// Its Dim operand must be one of 1D, 2D, 3D, or Cube, and its MS must be 0.
		/// See OpImageQuerySize for querying image types without level of detail.
		/// </summary>
		public int ImageId { get; set; }
		
		/// <summary>
		/// Level of Detail is used to compute which mipmap level to query, as described in the API specification.
		/// </summary>
		public int LevelOfDetailId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32((uint) ResultTypeId);
			ba.PushUInt32((uint) ResultId);
			ba.PushUInt32((uint) ImageId);
			ba.PushUInt32((uint) LevelOfDetailId);
			return ba.ToArray();
		}
	}
}
