using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Create a sampled image, containing both a sampler and an image.
	/// </summary>
	public class SampledImage : BaseInstruction {
		public override int WordCount => 5;
		public override Operation OpCode => Operation.SampledImage;
		
		/// <summary>
		/// Result Type must be the OpTypeSampledImage type.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Image is an object whose type is an OpTypeImage, whose Sampled operand is 0 or 1,
		/// and whose Dim operand is not SubpassData.
		/// </summary>
		public int ImageId { get; set; }
		
		/// <summary>
		/// Sampler must be an object whose type is OpTypeSampler.
		/// </summary>
		public int SamplerId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint) ResultTypeId);
			byteArray.PushUInt32((uint) ResultId);
			byteArray.PushUInt32((uint) ImageId);
			byteArray.PushUInt32((uint) SamplerId);
			return byteArray.ToArray();
		}
	}
}
