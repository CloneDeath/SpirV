using System;
using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Fetch a single texel from a sampled sparse image.
	/// </summary>
	public class ImageSparseFetch : BaseInstruction {
		public override int WordCount => 5 + (ImageOperands != null ? 1 : 0) + Ids.Length;
		public override Operation OpCode => Operation.ImageSparseFetch;
		
		/// <summary>
		/// Result Type must be an OpTypeStruct with two members.
		/// The first member’s type must be an integer type scalar.
		/// It will hold a Residency Code that can be passed to OpImageSparseTexelsResident.
		/// The second member must be a vector of four components of floating-point type or integer type.
		/// Its components must be the same as Sampled Type of the underlying OpTypeImage
		/// (unless that underlying Sampled Type is OpTypeVoid).
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Image must be an object whose type is OpTypeImage.
		/// Its Dim operand cannot be Cube.
		/// </summary>
		public int ImageId { get; set; }
		
		/// <summary>
		/// Coordinate is an integer scalar or vector containing (u[, v] … [, array layer])
		/// as needed by the definition of Sampled Image.
		/// </summary>
		public int CoordinateId { get; set; }
		
		/// <summary>
		/// Image Operands encodes what operands follow, as per Image Operands.
		/// </summary>
		public ImageOperands? ImageOperands { get; set; }
		
		public int[] Ids { get; set; } = Array.Empty<int>();
		
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
