using System;
using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Sample a sparse image doing depth-comparison using an explicit level of detail.
	/// </summary>
	public class ImageSparseSampleDrefExplicitLod : BaseInstruction
	{
		public override int WordCount => 7 + Ids.Length;
		public override Operation OpCode => Operation.ImageSparseSampleDrefExplicitLod;
		
		/// <summary>
		/// Result Type must be an OpTypeStruct with two members.
		/// The first member’s type must be an integer type scalar.
		/// It will hold a Residency Code that can be passed to OpImageSparseTexelsResident.
		/// The second member must be a scalar of integer type or floating-point type.
		/// It must be the same as Sampled Type of the underlying OpTypeImage.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Sampled Image must be an object whose type is OpTypeSampledImage.
		/// </summary>
		public int SampledImageId { get; set; }
		
		/// <summary>
		/// Coordinate must be a scalar or vector of floating-point type.
		/// It contains (u[, v] … [, array layer]) as needed by the definition of Sampled Image.
		/// It may be a vector larger than needed, but all unused components will appear after all used components.
		/// </summary>
		public int CoordinateId { get; set; }
		
		/// <summary>
		/// Dref is the depth-comparison reference value.
		/// </summary>
		public int DrefId { get; set; }
		
		/// <summary>
		/// Image Operands encodes what operands follow, as per Image Operands.
		/// At least one operand setting the level of detail must be present.
		/// </summary>
		public ImageOperands ImageOperands { get; set; }
		
		public int[] Ids { get; set; } = Array.Empty<int>();
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(SampledImageId);
			ba.PushUInt32(CoordinateId);
			ba.PushUInt32(DrefId);
			ba.PushUInt32((uint)ImageOperands);
			ba.PushUInt32(Ids);
			return ba.ToArray();
		}
	}
}
