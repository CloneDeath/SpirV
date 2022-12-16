using System;
using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Sample an image using an explicit level of detail.
	/// </summary>
	public class ImageSampleExplicitLod : BaseInstruction {
		public override int WordCount => 6 + Ids.Length;
		public override Operation OpCode => Operation.ImageSampleExplicitLod;
		
		/// <summary>
		/// Result Type must be a vector of four components of floating-point type or integer type.
		/// Its components must be the same as Sampled Type of the underlying OpTypeImage
		/// (unless that underlying Sampled Type is OpTypeVoid).
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Sampled Image must be an object whose type is OpTypeSampledImage.
		/// </summary>
		public int SampledImageId { get; set; }
		
		/// <summary>
		/// Coordinate must be a scalar or vector of floating-point type or integer type.
		/// It contains (u[, v] … [, array layer]) as needed by the definition of Sampled Image.
		/// Unless the Kernel capability is being used, it must be floating point.
		/// It may be a vector larger than needed, but all unused components will appear after all used components.
		/// </summary>
		public int CoordinateId { get; set; }
		
		/// <summary>
		/// Image Operands encodes what operands follow, as per Image Operands.
		/// At least one operand setting the level of detail must be present.
		/// </summary>
		public ImageOperands ImageOperands { get; set; }
		
		public int[] Ids { get; set; } = Array.Empty<int>();
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32((uint) ResultTypeId);
			ba.PushUInt32((uint) ResultId);
			ba.PushUInt32((uint) SampledImageId);
			ba.PushUInt32((uint) CoordinateId);
			ba.PushUInt32((uint) ImageOperands);
			foreach (var id in Ids) {
				ba.PushUInt32((uint) id);
			}
			return ba.ToArray();
		}
	}
}
