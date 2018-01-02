using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Read a texel from an image without a sampler.
	/// </summary>
	public class ImageRead : BaseInstruction {
		public override int WordCount => 5 + (ImageOperands != null ? 1 : 0) + Ids.Length;
		public override Operation OpCode => Operation.ImageRead;
		
		/// <summary>
		/// Result Type must be a scalar or vector of floating-point type or integer type.
		/// Its component type must be the same as Sampled Type of the OpTypeImage
		/// (unless that Sampled Type is OpTypeVoid).
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Image must be an object whose type is OpTypeImage with a Sampled operand of 0 or 2.
		/// If the Sampled operand is 2, then some dimensions require a capability;
		/// e.g., one of Image1D, ImageRect, ImageBuffer, ImageCubeArray, or ImageMSArray.
		/// 
		/// When the Image Dim operand is not SubpassData, the Image Format must not be Unknown,
		/// unless the StorageImageReadWithoutFormat Capability was declared.
		/// </summary>
		public int ImageId { get; set; }
		
		/// <summary>
		/// Coordinate is an integer scalar or vector containing non-normalized texel coordinates
		/// (u[, v] … [, array layer]) as needed by the definition of Image.
		/// If the coordinates are outside the image, the memory location that is accessed is undefined.
		/// 
		/// When the Image Dim operand is SubpassData, Coordinate is relative to the current fragment location.
		/// That is, the integer value (rounded down) of the current fragment’s window-relative (x, y) coordinate
		/// is added to (u, v).
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
			ba.PushUInt32(Ids);
			return ba.ToArray();
		}
	}
}
