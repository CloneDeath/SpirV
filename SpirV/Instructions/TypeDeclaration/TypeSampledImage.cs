using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare a sampled image type, the Result Type of OpSampledImage, or an externally combined sampler and image.
	/// This type is opaque: values of this type have no defined physical size or bit pattern.
	/// </summary>
	public class TypeSampledImage : BaseInstruction
	{
		public TypeSampledImage(int resultId, int imageTypeId) {
			ResultId = resultId;
			ImageTypeId = imageTypeId;
		}

		public override int WordCount => 3;
		public override Operation OpCode => Operation.TypeSampledImage;

		public int ResultId { get; set; }

		/// <summary>
		/// Image Type must be an OpTypeImage.It is the type of the image in the combined sampler and image type.
		/// </summary>
		public int ImageTypeId { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushUInt32((uint)ImageTypeId);
			return byteArray.ToArray();
		}
	}
}
