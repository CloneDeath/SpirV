using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare a new image type. Consumed, for example, by OpTypeSampledImage. 
	/// This type is opaque: values of this type have no defined physical size or bit pattern.
	/// </summary>
	public class TypeImage : BaseInstruction
	{
		public TypeImage(int resultId, int sampledTypeId, Dim dimensionality, ImageDepth depth, bool hasArrayedContent,
		                 Samples samples, SamplerPresence samplerPresence, ImageFormat imageFormat, AccessQualifier? accessQualifier = null) {
			ResultId = resultId;
			SampledTypeId = sampledTypeId;
			Dimensionality = dimensionality;
			Depth = depth;
			HasArrayedContent = hasArrayedContent;
			Samples = samples;
			SamplerPresence = samplerPresence;
			ImageFormat = imageFormat;
			AccessQualifier = accessQualifier;
		}
		public override int WordCount => 9 + (AccessQualifier == null ? 0 : 1);
		public override Operation OpCode => Operation.TypeImage;

		public int ResultId { get; set; }

		/// <summary>
		/// Sampled Type is the type of the components that result from sampling or reading from this image type.
		/// Must be a scalar numerical type or OpTypeVoid.
		/// </summary>
		public int SampledTypeId { get; set; }

		/// <summary>
		/// Dim is the image dimensionality(Dim).
		/// 
		/// If Dim is SubpassData, Sampled must be 2 (SamplerPresence.Never), Image Format must be Unknown, 
		/// and the Execution Model must be Fragment.
		/// </summary>
		public Dim Dimensionality { get; set; }

		/// <summary>
		/// Depth is whether or not this image is a depth image. 
		/// (Note that whether or not depth comparisons are actually done is a property of the sampling opcode, not of this type declaration.)
		/// </summary>
		public ImageDepth Depth { get; set; }

		/// <summary>
		/// Arrayed must be one of the following indicated values:
		/// 0 indicates non-arrayed content
		/// 1 indicates arrayed content
		/// </summary>
		public bool HasArrayedContent { get; set; }

		/// <summary>
		/// MS must be one of the following indicated values:
		/// </summary>
		public Samples Samples { get; set; }

		/// <summary>
		/// Sampled indicates whether or not this image will be accessed in combination with a sampler, 
		/// and must be one of the following values:
		/// 0 indicates this is only known at run time, not at compile time
		/// 1 indicates will be used with sampler
		/// 2 indicates will be used without a sampler (a storage image)
		/// </summary>
		public SamplerPresence SamplerPresence { get; set; }

		/// <summary>
		/// Image Format is the Image Format, which can be Unknown, depending on the client API.
		/// </summary>
		public ImageFormat ImageFormat { get; set; }

		/// <summary>
		/// Access Qualifier is an image Access Qualifier.
		/// </summary>
		public AccessQualifier? AccessQualifier { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushUInt32((uint)SampledTypeId);
			byteArray.PushUInt32((uint)Dimensionality);
			byteArray.PushUInt32((uint)Depth);
			byteArray.PushUInt32(HasArrayedContent ? 1U : 0);
			byteArray.PushUInt32((uint)Samples);
			byteArray.PushUInt32((uint)SamplerPresence);
			byteArray.PushUInt32((uint)ImageFormat);
			if (AccessQualifier != null) byteArray.PushUInt32((uint)AccessQualifier);
			return byteArray.ToArray();
		}
	}

	public enum ImageDepth
	{
		/// <summary>
		/// 0 indicates not a depth image
		/// </summary>
		Missing = 0,

		/// <summary>
		/// 1 indicates a depth image
		/// </summary>
		Present = 1,

		/// <summary>
		/// 2 means no indication as to whether this is a depth or non-depth image
		/// </summary>
		Unknown = 2
	}

	public enum Samples
	{
		/// <summary>
		/// 0 indicates single-sampled content
		/// </summary>
		Single = 0,

		/// <summary>
		/// 1 indicates multisampled content
		/// </summary>
		Multiple = 1
	}

	public enum SamplerPresence
	{
		/// <summary>
		/// 0 indicates this is only known at run time, not at compile time
		/// </summary>
		KnownAtRuntime = 0,

		/// <summary>
		/// 1 indicates will be used with sampler
		/// </summary>
		Always = 1,

		/// <summary>
		/// 2 indicates will be used without a sampler (a storage image)
		/// </summary>
		Never = 2
	}
}
