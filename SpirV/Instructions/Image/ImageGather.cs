using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Gathers the requested component from four texels.
	/// </summary>
	public class ImageGather : BaseInstruction {
		public override int WordCount => 6 + (ImageOperands != null ? 1 : 0) + Ids.Length;
		public override Operation OpCode => Operation.ImageGather;
		
		/// <summary>
		/// Result Type must be a vector of four components of floating-point type or integer type.
		/// Its components must be the same as Sampled Type of the underlying OpTypeImage
		/// (unless that underlying Sampled Type is OpTypeVoid). It has one component per gathered texel.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Sampled Image must be an object whose type is OpTypeSampledImage.
		/// Its OpTypeImage must have a Dim of 2D, Cube, or Rect.
		/// </summary>
		public int SampledImageId { get; set; }
		
		/// <summary>
		/// Coordinate must be a scalar or vector of floating-point type.
		/// It contains (u[, v] … [, array layer]) as needed by the definition of Sampled Image.
		/// </summary>
		public int CoordinateId { get; set; }
		
		/// <summary>
		/// Component is the component number that will be gathered from all four texels.
		/// It must be 0, 1, 2 or 3.
		/// </summary>
		public int ComponentId { get; set; }
		
		/// <summary>
		/// Image Operands encodes what operands follow, as per Image Operands.
		/// </summary>
		public ImageOperands? ImageOperands { get; set; }
		
		public int[] Ids { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32((uint) ResultTypeId);
			ba.PushUInt32((uint) ResultId);
			ba.PushUInt32((uint) SampledImageId);
			ba.PushUInt32((uint) CoordinateId);
			ba.PushUInt32((uint) ComponentId);
			if (ImageOperands != null) ba.PushUInt32((uint) ImageOperands);
			foreach (var id in Ids) {
				ba.PushUInt32((uint) id);
			}
			return ba.ToArray();
		}
	}
}
