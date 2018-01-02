using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Extract the image from a sampled image.
	/// </summary>
	public class Image : BaseInstruction {
		public override int WordCount => 4;
		public override Operation OpCode => Operation.Image;
		
		/// <summary>
		/// Result Type must be OpTypeImage.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Sampled Image must have type OpTypeSampledImage whose Image Type is the same as Result Type.
		/// </summary>
		public int SampledImageId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32((uint) ResultTypeId);
			ba.PushUInt32((uint) ResultId);
			ba.PushUInt32((uint) SampledImageId);
			return ba.ToArray();
		}
	}
}
