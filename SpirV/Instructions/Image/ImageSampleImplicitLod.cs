using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Sample an image with an implicit level of detail.
	/// </summary>
	public class ImageSampleImplicitLod : BaseInstruction
	{
		public ImageSampleImplicitLod(int resultTypeId, int resultId, int sampledImageId,
		                              int coordinateId, ImageOperands? imageOperands = null, params int[] ids) {
			ResultTypeId = resultTypeId;
			ResultId = resultId;
			SampledImageId = sampledImageId;
			CoordinateId = coordinateId;
			ImageOperands = imageOperands;
			Ids = ids;
		}

		public override int WordCount => 5 + (ImageOperands != null ? 1 : 0) + Ids.Length;
		public override Operation OpCode => Operation.ImageSampleImplicitLod;

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
		/// Coordinate must be a scalar or vector of floating-point type.
		/// It contains (u [,v] . . .  [,array layer]) as needed by the definition of Sampled Image.
		/// It may be a vector larger than needed, but all unused components will appear after all used components.
		/// </summary>
		public int CoordinateId { get; set; }

		/// <summary>
		/// Image Operands encodes what operands follow, as per Image Operands.
		/// </summary>
		public ImageOperands? ImageOperands { get; set; }

		/// <summary>
		/// This instruction is only valid in the Fragment Execution Model.
		/// In addition, it consumes an implicit derivative that can be affected by code motion.
		/// </summary>
		public int[] Ids { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultTypeId);
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushUInt32((uint)SampledImageId);
			byteArray.PushUInt32((uint)CoordinateId);
			if (ImageOperands != null) byteArray.PushUInt32((uint)ImageOperands);
			foreach (var id in Ids) {
				byteArray.PushUInt32((uint)id);
			}
			return byteArray.ToArray();
		}
	}
}
