// ReSharper disable InconsistentNaming
namespace SpirV.Native {
	public enum Decoration
	{
		/// <summary>
		/// Allow reduced precision operations. To be used as described in Relaxed Precision.
		/// </summary>
		RelaxedPrecision = 0,

		/// <summary>
		/// Apply to a scalar specialization constant. Forms the API linkage for setting a specialized value. See specialization.
		/// 
		/// Extra Operands: [Literal Number] Specialization Constant Id
		/// </summary>
		SpecId = 1,

		/// <summary>
		/// Apply to a structure type to establish it is a non-SSBO-like shader-interface block.
		/// </summary>
		Block = 2,

		/// <summary>
		/// Apply to a structure type to establish it is an SSBO-like shader-interface block.
		/// </summary>
		BufferBlock = 3,

		/// <summary>
		/// Applies only to a member of a structure type. Only valid on a matrix or array whose most basic 
		/// element is a matrix. Indicates that components within a row are contiguous in memory.
		/// </summary>
		RowMajor = 4,

		/// <summary>
		/// Applies only to a member of a structure type. Only valid on a matrix or array whose most basic
		/// element is a matrix. Indicates that components within a column are contiguous in memory.
		/// </summary>
		ColMajor = 5,

		/// <summary>
		/// Apply to an array type to specify the stride, in bytes, of the array’s elements. Must not be
		/// applied to anything other than an array type.
		/// 
		/// Extra Operands: [Literal Number] Array Stride
		/// </summary>
		ArrayStride = 6,

		/// <summary>
		/// Applies only to a member of a structure type. Only valid on a matrix or array whose most basic 
		/// element is a matrix. Specifies the stride of rows in a RowMajor-decorated matrix, or columns in 
		/// a ColMajor-decorated matrix.
		/// 
		/// Extra Operands: [Literal Number] Matrix Stride
		/// </summary>
		MatrixStride = 7,

		/// <summary>
		/// Apply to a structure type to get GLSL shared memory layout.
		/// </summary>
		GLSLShared = 8,

		/// <summary>
		/// Apply to a structure type to get GLSL packed memory layout.
		/// </summary>
		GLSLPacked = 9,

		/// <summary>
		/// Apply to a structure type, to marks it as "packed", indicating that the alignment 
		/// of the structure is one and that there is no padding between structure members.
		/// </summary>
		CPacked = 10,

		/// <summary>
		/// Apply to an object or a member of a structure type. Indicates which built-in variable 
		/// the entity represents. See BuiltIn for more information.
		/// 
		/// Extra Operators: BuiltIn
		/// </summary>
		BuiltIn = 11,

		/// <summary>
		/// Apply to an object or a member of a structure type. 
		/// Indicates that linear, non-perspective correct, interpolation must be used. 
		/// The object or member must be a scalar or vector of floating-point type. 
		/// Arrays of these types are also allowed. 
		/// Only valid for the Input and Output Storage Classes.
		/// </summary>
		NoPerspective = 13,

		/// <summary>
		/// Apply to an object or a member of a structure type. 
		/// Indicates no interpolation will be done. 
		/// The non-interpolated value will come from a vertex, as described in the API specification. 
		/// The object or member must be a scalar or vector of floating-point type or integer type. 
		/// Arrays of these types are also allowed. 
		/// Only valid for the Input and OutputStorage Classes.
		/// </summary>
		Flat = 14,

		/// <summary>
		/// Apply to an object or a member of a structure type. 
		/// Indicates a tessellation patch. 
		/// The object or member must be a scalar or vector of floating-point type. 
		/// Arrays of these types are also allowed. 
		/// Only valid for the Input and Output Storage Classes. 
		/// Invalid to use on objects or types referenced by non-tessellation Execution Models.
		/// </summary>
		Patch = 15,

		/// <summary>
		/// Apply to an object or a member of a structure type. 
		/// When used with multi-sampling rasterization, allows a single interpolation location for an entire pixel. 
		/// The interpolation location must lie in both the pixel and in the primitive being rasterized. 
		/// The object or member must be a scalar or vector of floating-point type.
		/// Arrays of these types are also allowed. 
		/// Only valid for the Input and Output Storage Classes.
		/// </summary>
		Centroid = 16,

		/// <summary>
		/// Apply to an object or a member of a structure type. 
		/// When used with multi-sampling rasterization, requires per-sample interpolation.
		/// The interpolation locations must be the locations of the samples lying in both the pixel 
		/// and in the primitive being rasterized. 
		/// The object or member must be a scalar or vector of floating-point type.
		/// Arrays of these types are also allowed. 
		/// Only valid for the Input and Output Storage Classes.
		/// </summary>
		Sample = 17,

		/// <summary>
		/// Apply to a variable, to indicate expressions computing its value be done invariant 
		/// with respect to other modules computing the same expressions.
		/// </summary>
		Invariant = 18,

		/// <summary>
		/// Apply to a variable, to indicate the compiler may compile as if there is no aliasing. 
		/// See the Aliasing section for more detail.
		/// </summary>
		Restrict = 19,

		/// <summary>
		/// Apply to a variable, to indicate the compiler is to generate accesses to the variable that work
		/// correctly in the presence of aliasing. See the Aliasing section for more detail.
		/// </summary>
		Aliased = 20,

		/// <summary>
		/// Apply to an object or a member of a structure type. 
		/// Can only be used for objects declared as storage images (see OpTypeImage) or in 
		/// the Uniform Storage Class with the BufferBlock Decoration. 
		/// This indicates the memory holding the variable is volatile memory. 
		/// Accesses to volatile memory cannot be eliminated, duplicated, or combined with other accesses. 
		/// The variable cannot be in the Function Storage Class.
		/// </summary>
		Volatile = 21,

		/// <summary>
		/// Indicates that a global variable is constant and will never be modified. 
		/// Only allowed on global variables.
		/// </summary>
		Constant = 22,

		/// <summary>
		/// Apply to an object or a member of a structure type. 
		/// Can only be used for objects declared as storage images (see OpTypeImage) or in the
		/// Uniform Storage Class with the BufferBlock Decoration. 
		/// This indicates the memory backing the object is coherent.
		/// </summary>
		Coherent = 23,

		/// <summary>
		/// Apply to an object or a member of a structure type. 
		/// Can only be used for objects declared as storage images (see OpTypeImage) or in the
		/// Uniform Storage Class with the BufferBlock Decoration. 
		/// This indicates the memory holding the variable is not writable, and that this moduledoes not write to it.
		/// </summary>
		NonWritable = 24,

		/// <summary>
		/// Apply to an object or a member of a structure type. 
		/// Can only be used for objects declared as storage images (see OpTypeImage) or in the
		/// Uniform Storage Class with the BufferBlock Decoration. 
		/// This indicates the memory holding the variable is not readable, and that this module does not read from it.
		/// </summary>
		NonReadable = 25,

		/// <summary>
		/// Apply to an object or a member of a structure type. 
		/// Asserts that the value backing the decorated id is dynamically uniform, hence the
		/// consumer is allowed to assume this is the case.
		/// </summary>
		Uniform = 26,

		/// <summary>
		/// Indicates that a conversion to an integer type which is outside the representable range of
		/// Result Type will be clamped to the nearest representable value of Result Type.
		/// NaN will be converted to 0.
		/// This decoration can only be applied to conversion instructions to integer types, not including the
		/// OpSatConvertUToS and OpSatConvertSToU instructions.
		/// </summary>
		SaturatedConversion = 28,

		/// <summary>
		/// Apply to an object or a member of a structure type. 
		/// Indicates the stream number to put an output on. 
		/// Only valid for the Output Storage Class and the Geometry Execution Model.
		/// 
		/// Extra Operands: [Literal Number] Stream Number
		/// </summary>
		Stream = 29,

		/// <summary>
		/// Apply to a variable or a structure-type member.
		/// Forms the main linkage for Storage Class Input and Outputvariables:
		/// - between the API and vertex-stage inputs,
		/// - between consecutive programmable stages, or
		/// - between fragment-stage outputs and the API.
		/// Also can tag variables or structure-type members in the UniformConstant Storage Class for linkage with the API. 
		/// Only valid for the Input, Output, and UniformConstantStorage Classes.
		/// 
		/// Extra Operands: [Literal Number] Location
		/// </summary>
		Location = 30,

		/// <summary>
		/// Apply to an object or a member of a structure type. 
		/// Indicates which component within a Location will be taken by the decorated entity.
		/// Only valid for the Input and Output Storage Classes.
		/// 
		/// Extra Operands: [Literal Number] Component
		/// </summary>
		Component = 31,

		/// <summary>
		/// Apply to a variable to identify a blend equation input index, used as described in the API specification. 
		/// Only valid for the Output Storage Class and the Fragment Execution Model.
		/// 
		/// Extra Operands: [Literal Number] Index
		/// </summary>
		Index = 32,

		/// <summary>
		/// Apply to a variable. 
		/// Part of the main linkage between the API and SPIR-V modules for memory buffers, images, etc. 
		/// See the API specification for more information.
		/// 
		/// Extra Operands: [Literal Number] Binding Point
		/// </summary>
		Binding = 33,

		/// <summary>
		/// Apply to a variable. 
		/// Part of the main linkage between the API and SPIR-V modules for memory buffers, images, etc. 
		/// See the API specification for more information.
		/// 
		/// Extra Operands: [Literal Number] Descriptor Set
		/// </summary>
		DescriptorSet = 34,

		/// <summary>
		/// Apply to a structure-type member. 
		/// This gives the byte offset of the member relative to the beginning of the structure. 
		/// Can be used, for example, by both uniform and transform-feedback buffers. 
		/// It must not cause any overlap of the structure’s members, or overflow of a transform-feedback buffer’s XfbStride.
		/// 
		/// Extra Operands: [Literal Number] Byte Offset
		/// </summary>
		Offset = 35,

		/// <summary>
		/// Apply to an object or a member of a structure type. 
		/// Indicates which transform-feedback buffer an output is written to. 
		/// Only valid for the Output Storage Classes of vertex processing Execution Models.
		/// 
		/// Extra Operands: [Literal Number] XFB Buffer Number
		/// </summary>
		XfbBuffer = 36,

		/// <summary>
		/// Apply to anything XfbBuffer is applied to.
		/// Specifies the stride, in bytes, of transform-feedback buffer vertices. 
		/// If the transform-feedback buffer is capturing any double-precision components, the stride must 
		/// be a multiple of 8, otherwise it must be a multiple of 4.
		/// 
		/// Extra Operands: [Literal Number] XFB Stride
		/// </summary>
		XfbStride = 37,

		/// <summary>
		/// Indicates a function return value or parameter attribute.
		/// 
		/// Extra Operands: [Function Parameter Attribute] Function Parameter Attribute
		/// </summary>
		FuncParamAttr = 38,

		/// <summary>
		/// Indicates a floating-point rounding mode.
		/// 
		/// Extra Operands: [FP Rounding Mode] Floating-Point Rounding Mode.
		/// </summary>
		FPRoundingMode = 39,

		/// <summary>
		/// Indicates a floating-point fast math flag.
		/// 
		/// Extra Operands: [FP Fast Math Mode] Fast Math Mode
		/// </summary>
		FPFastMathMode = 40,

		/// <summary>
		/// Associate linkage attributes to values. 
		/// Only valid on OpFunction or global (module scope) OpVariable. 
		/// See linkage.
		/// 
		/// Extra Operands: [Literal String] Name, [LinkageType] Linkage Type
		/// </summary>
		LinkageAttributes = 41,

		/// <summary>
		/// Apply to an arithmetic instruction to indicate the operation cannot be combined with another
		/// instruction to form a single operation. For example, if applied to an OpFMul, that multiply
		/// can’t be combined with an addition to yield a fused multiply-add operation. Furthermore, such
		/// operations are not allowed to reassociate; e.g.,add(a + add(b+c)) cannot be transformed to
		/// add(add(a+b) + c).
		/// </summary>
		NoContraction = 42,

		/// <summary>
		/// Apply to a variable to provide an input-target index (as described in the API specification).
		/// Only valid in the Fragment Execution Model and for variables of type OpTypeImage with a Dim
		/// operand of SubpassData.
		/// 
		/// Extra Operands: [Literal Number] Attachment Index
		/// </summary>
		InputAttachmentIndex = 43,

		/// <summary>
		/// Apply to a pointer. This declares a known minimum alignment the pointer has.
		/// 
		/// Extra Operands: [Literal Number] Alighment
		/// </summary>
		Alignment = 44,
		
		Max = 0x7fffffff
	}
}