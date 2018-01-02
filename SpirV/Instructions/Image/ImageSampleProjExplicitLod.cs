using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Sample an image with a project coordinate using an explicit level of detail.
	/// </summary>
	public class ImageSampleProjExplicitLod : BaseInstruction {
		public override int WordCount => 6 + Ids.Length;
		public override Operation OpCode => Operation.ImageSampleProjImplicitLod;
		
		/// <summary>
		/// Result Type must be a vector of four components of floating-point type or integer type.
		/// Its components must be the same as Sampled Type of the underlying OpTypeImage
		/// (unless that underlying Sampled Type is OpTypeVoid).
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Sampled Image must be an object whose type is OpTypeSampledImage.
		/// The Dim operand of the underlying OpTypeImage must be 1D, 2D, 3D, or Rect,
		/// and the Arrayed and MS operands must be 0.
		/// </summary>
		public int SampledImageId { get; set; }
		
		/// <summary>
		/// Coordinate is a floating-point vector containing (u [, v] [, w], q), as needed by the definition of
		/// Sampled Image, with the q component consumed for the projective division.
		/// That is, the actual sample coordinate will be (u/q [, v/q] [, w/q]),
		/// as needed by the definition of Sampled Image.
		/// It may be a vector larger than needed, but all unused components will appear after all used components.
		/// </summary>
		public int CoordinateId { get; set; }
		
		/// <summary>
		/// Image Operands encodes what operands follow, as per Image Operands.
		/// </summary>
		public ImageOperands ImageOperands{ get; set; }
		
		public int[] Ids { get; set; }
		
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
