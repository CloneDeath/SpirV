using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Read a texel from a sparse image without a sampler.
	/// </summary>
	public class ImageSparseRead : BaseInstruction
	{
		public override int WordCount => 5 + (ImageOperands != null ? 1 : 0) + Ids.Length;
		public override Operation OpCode => Operation.ImageSparseRead;
		
		/// <summary>
		/// Result Type must be an OpTypeStruct with two members.
		/// The first member’s type must be an integer type scalar.
		/// It will hold a Residency Code that can be passed to OpImageSparseTexelsResident.
		/// The second member must be a scalar or vector of floating-point type or integer type.
		/// Its component type must be the same as Sampled Type of the OpTypeImage
		/// (unless that Sampled Type is OpTypeVoid).
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Image must be an object whose type is OpTypeImage with a Sampled operand of 2.
		/// 
		/// The Image Format must not be Unknown, unless the StorageImageReadWithoutFormat Capability was declared.
		/// </summary>
		public int ImageId { get; set; }
		
		/// <summary>
		/// Coordinate is an integer scalar or vector containing non-normalized texel coordinates
		/// (u[, v] … [, array layer]) as needed by the definition of Image.
		/// If the coordinates are outside the image, the memory location that is accessed is undefined.
		/// </summary>
		public int CoordinateId { get; set; }
		
		/// <summary>
		/// Image Operands encodes what operands follow, as per Image Operands.
		/// </summary>
		public ImageOperands? ImageOperands { get; set; }
		
		public int[] Ids { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(ImageId);
			ba.PushUInt32(CoordinateId);
			if (ImageOperands != null) ba.PushUInt32((uint)ImageOperands);
			ba.PushUInt32(Ids);
			return ba.ToArray();
		}
	}
}
