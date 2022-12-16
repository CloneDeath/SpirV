using System;
using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Write a texel to an image without a sampler.
	/// </summary>
	public class ImageWrite : BaseInstruction {
		public override int WordCount => 4 + (ImageOperands != null ? 1 : 0) + Ids.Length;
		public override Operation OpCode => Operation.ImageWrite;
		
		/// <summary>
		/// Image must be an object whose type is OpTypeImage with a Sampled operand of 0 or 2.
		/// If the Sampled operand is 2, then some dimensions require a capability; e.g.,
		/// one of Image1D, ImageRect, ImageBuffer, ImageCubeArray, or ImageMSArray.
		/// Its Dim operand cannot be SubpassData.
		/// 
		/// The Image Format must not be Unknown, unless the StorageImageWriteWithoutFormat Capability was declared.
		/// </summary>
		public int ImageId { get; set; }
		
		/// <summary>
		/// Coordinate is an integer scalar or vector containing non-normalized texel coordinates
		/// (u[, v] … [, array layer]) as needed by the definition of Image.
		/// If the coordinates are outside the image, the memory location that is accessed is undefined.
		/// </summary>
		public int CoordinateId { get; set; }
		
		/// <summary>
		/// Texel is the data to write.
		/// Its component type must be the same as Sampled Type of the OpTypeImage
		/// (unless that Sampled Type is OpTypeVoid).
		/// </summary>
		public int TexelId { get; set; }
		
		/// <summary>
		/// Image Operands encodes what operands follow, as per Image Operands.
		/// </summary>
		public ImageOperands? ImageOperands { get; set; }
		
		public int[] Ids { get; set; } = Array.Empty<int>();
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ImageId);
			ba.PushUInt32(CoordinateId);
			ba.PushUInt32(TexelId);
			if (ImageOperands != null) ba.PushUInt32((uint)ImageOperands);
			ba.PushUInt32(Ids);
			return ba.ToArray();
		}
	}
}
