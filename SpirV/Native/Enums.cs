// ReSharper disable InconsistentNaming

namespace SpirV.Native
{
	public enum SourceLanguage {
		Unknown = 0,
		ESSL = 1,
		GLSL = 2,
		OpenCL_C = 3,
		OpenCL_CPP = 4,
		Max = 0x7fffffff
	}

	public enum ExecutionModel {
		Vertex = 0,
		TessellationControl = 1,
		TessellationEvaluation = 2,
		Geometry = 3,
		Fragment = 4,
		GLCompute = 5,
		Kernel = 6,
		Max = 0x7fffffff
	}

	public enum AddressingModel {
		Logical = 0,
		Physical32 = 1,
		Physical64 = 2,
		Max = 0x7fffffff
	}

	public enum MemoryModel {
		Simple = 0,
		GLSL450 = 1,
		OpenCL = 2,
		Max = 0x7fffffff
	}

	public enum Dim {
		Dim1D = 0,
		Dim2D = 1,
		Dim3D = 2,
		Cube = 3,
		Rect = 4,
		Buffer = 5,
		SubpassData = 6
	}

	public enum ImageFormat {
		Unknown = 0,
		Rgba32f = 1,
		Rgba16f = 2,
		R32f = 3,
		Rgba8 = 4,
		Rgba8Snorm = 5,
		Rg32f = 6,
		Rg16f = 7,
		R11fG11fB10f = 8,
		R16f = 9,
		Rgba16 = 10,
		Rgb10A2 = 11,
		Rg16 = 12,
		Rg8 = 13,
		R16 = 14,
		R8 = 15,
		Rgba16Snorm = 16,
		Rg16Snorm = 17,
		Rg8Snorm = 18,
		R16Snorm = 19,
		R8Snorm = 20,
		Rgba32i = 21,
		Rgba16i = 22,
		Rgba8i = 23,
		R32i = 24,
		Rg32i = 25,
		Rg16i = 26,
		Rg8i = 27,
		R16i = 28,
		R8i = 29,
		Rgba32ui = 30,
		Rgba16ui = 31,
		Rgba8ui = 32,
		R32ui = 33,
		Rgb10a2ui = 34,
		Rg32ui = 35,
		Rg16ui = 36,
		Rg8ui = 37,
		R16ui = 38,
		R8ui = 39
	}

	public enum ImageChannelOrder {
		R = 0,
		A = 1,
		RG = 2,
		RA = 3,
		RGB = 4,
		RGBA = 5,
		BGRA = 6,
		ARGB = 7,
		Intensity = 8,
		Luminance = 9,
		Rx = 10,
		RGx = 11,
		RGBx = 12,
		Depth = 13,
		DepthStencil = 14,
		sRGB = 15,
		sRGBx = 16,
		sRGBA = 17,
		sBGRA = 18,
		ABGR = 19,
		Max = 0x7fffffff
	}

	public enum ImageChannelDataType {
		SnormInt8 = 0,
		SnormInt16 = 1,
		UnormInt8 = 2,
		UnormInt16 = 3,
		UnormShort565 = 4,
		UnormShort555 = 5,
		UnormInt101010 = 6,
		SignedInt8 = 7,
		SignedInt16 = 8,
		SignedInt32 = 9,
		UnsignedInt8 = 10,
		UnsignedInt16 = 11,
		UnsignedInt32 = 12,
		HalfFloat = 13,
		Float = 14,
		UnormInt24 = 15,
		UnormInt101010_2 = 16,
		Max = 0x7fffffff
	}

	public enum ImageOperandsShift {
		BiasShift = 0,
		LodShift = 1,
		GradShift = 2,
		ConstOffsetShift = 3,
		OffsetShift = 4,
		ConstOffsetsShift = 5,
		SampleShift = 6,
		MinLodShift = 7,
		Max = 0x7fffffff
	}

	public enum FPFastMathModeShift {
		NotNaNShift = 0,
		NotInfShift = 1,
		NSZShift = 2,
		AllowRecipShift = 3,
		FastShift = 4,
		Max = 0x7fffffff
	}

	public enum FPFastMathModeMask {
		MaskNone = 0,
		NotNaNMask = 0x00000001,
		NotInfMask = 0x00000002,
		NSZMask = 0x00000004,
		AllowRecipMask = 0x00000008,
		FastMask = 0x00000010
	}

	public enum FPRoundingMode {
		RTE = 0,
		RTZ = 1,
		RTP = 2,
		RTN = 3,
		Max = 0x7fffffff
	}

	public enum LinkageType {
		Export = 0,
		Import = 1,
		Max = 0x7fffffff
	}

	public enum FunctionParameterAttribute {
		Zext = 0,
		Sext = 1,
		ByVal = 2,
		Sret = 3,
		NoAlias = 4,
		NoCapture = 5,
		NoWrite = 6,
		NoReadWrite = 7,
		Max = 0x7fffffff
	}

	public enum SelectionControlShift {
		FlattenShift = 0,
		DontFlattenShift = 1,
		Max = 0x7fffffff
	}

	public enum SelectionControlMask {
		None = 0,
		Flatten = 0x00000001,
		DontFlatten = 0x00000002
	}

	public enum LoopControlShift {
		UnrollShift = 0,
		DontUnrollShift = 1,
		Max = 0x7fffffff
	}

	public enum LoopControlMask {
		None = 0,
		Unroll = 0x00000001,
		DontUnroll = 0x00000002
	}

	public enum FunctionControlShift {
		InlineShift = 0,
		DontInlineShift = 1,
		PureShift = 2,
		ConstShift = 3
	}

	public enum MemorySemanticsShift {
		AcquireShift = 1,
		ReleaseShift = 2,
		AcquireReleaseShift = 3,
		SequentiallyConsistentShift = 4,
		UniformMemoryShift = 6,
		SubgroupMemoryShift = 7,
		WorkgroupMemoryShift = 8,
		CrossWorkgroupMemoryShift = 9,
		AtomicCounterMemoryShift = 10,
		ImageMemoryShift = 11,
		Max = 0x7fffffff
	}

	public enum MemoryAccessShift {
		VolatileShift = 0,
		AlignedShift = 1,
		NontemporalShift = 2
	}

	public enum GroupOperation {
		Reduce = 0,
		InclusiveScan = 1,
		ExclusiveScan = 2,
		Max = 0x7fffffff
	}

	public enum KernelEnqueueFlags {
		NoWait = 0,
		WaitKernel = 1,
		WaitWorkGroup = 2,
		Max = 0x7fffffff
	}

	public enum KernelProfilingInfoShift {
		CmdExecTimeShift = 0,
		Max = 0x7fffffff
	}

	public enum KernelProfilingInfoMask {
		MaskNone = 0,
		CmdExecTimeMask = 0x00000001
	}

	public enum Capability {
		Matrix = 0,
		Shader = 1,
		Geometry = 2,
		Tessellation = 3,
		Addresses = 4,
		Linkage = 5,
		Kernel = 6,
		Vector16 = 7,
		Float16Buffer = 8,
		Float16 = 9,
		Float64 = 10,
		Int64 = 11,
		Int64Atomics = 12,
		ImageBasic = 13,
		ImageReadWrite = 14,
		ImageMipmap = 15,
		Pipes = 17,
		Groups = 18,
		DeviceEnqueue = 19,
		LiteralSampler = 20,
		AtomicStorage = 21,
		Int16 = 22,
		TessellationPointSize = 23,
		GeometryPointSize = 24,
		ImageGatherExtended = 25,
		StorageImageMultisample = 27,
		UniformBufferArrayDynamicIndexing = 28,
		SampledImageArrayDynamicIndexing = 29,
		StorageBufferArrayDynamicIndexing = 30,
		StorageImageArrayDynamicIndexing = 31,
		ClipDistance = 32,
		CullDistance = 33,
		ImageCubeArray = 34,
		SampleRateShading = 35,
		ImageRect = 36,
		SampledRect = 37,
		GenericPointer = 38,
		Int8 = 39,
		InputAttachment = 40,
		SparseResidency = 41,
		MinLod = 42,
		Sampled1D = 43,
		Image1D = 44,
		SampledCubeArray = 45,
		SampledBuffer = 46,
		ImageBuffer = 47,
		ImageMSArray = 48,
		StorageImageExtendedFormats = 49,
		ImageQuery = 50,
		DerivativeControl = 51,
		InterpolationFunction = 52,
		TransformFeedback = 53,
		GeometryStreams = 54,
		StorageImageReadWithoutFormat = 55,
		StorageImageWriteWithoutFormat = 56,
		MultiViewport = 57,
		Max = 0x7fffffff
	}
}
