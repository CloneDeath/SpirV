using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Fetch a single texel from a sampled image.
	/// </summary>
	public class ImageFetch : BaseInstruction {
		public override int WordCount => 5 + (ImageOperands != null ? 1 : 0) + Ids.Length;
		public override Operation OpCode => Operation.ImageFetch;
		
		/// <summary>
		/// Result Type must be a vector of four components of floating-point type or integer type.
		/// Its components must be the same as Sampled Type of the underlying OpTypeImage
		/// (unless that underlying Sampled Type is OpTypeVoid).
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Image must be an object whose type is OpTypeImage.
		/// Its Dim operand cannot be Cube, and its Sampled operand must be 1.
		/// </summary>
		public int ImageId { get; set; }
		
		/// <summary>
		/// Coordinate is an integer scalar or vector containing (u[, v] … [, array layer]) as needed
		/// by the definition of Sampled Image.
		/// </summary>
		public int CoordinateId { get; set; }
		
		/// <summary>
		/// Image Operands encodes what operands follow, as per Image Operands.
		/// </summary>
		public ImageOperands? ImageOperands { get; set; }
		
		public int[] Ids { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32((uint) ResultTypeId);
			ba.PushUInt32((uint) ResultId);
			ba.PushUInt32((uint) ImageId);
			ba.PushUInt32((uint) CoordinateId);
			if (ImageOperands != null) ba.PushUInt32((uint) ImageOperands);
			foreach (var id in Ids) {
				ba.PushUInt32((uint) id);
			}
			return ba.ToArray();
		}
	}
}
