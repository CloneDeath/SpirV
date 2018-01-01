namespace SpirV.Native {
	public enum ExecutionMode {
		/// <summary>
		/// Number of times to invoke the geometry stage for each input primitive received. 
		/// The default is to run once for each input primitive. 
		/// If greater than the target-dependent maximum, it will fail to compile. 
		/// Only valid with the Geometry Execution Model.
		/// 
		/// Extra Operands: [Literal Number] Number of Invocations
		/// </summary>
		Invocations = 0,

		/// <summary>
		/// Requests the tessellation primitive generator to divide edges into a collection of equal-sized segments. 
		/// Only valid with one of the tessellation Execution Models.
		/// </summary>
		SpacingEqual = 1,

		/// <summary>
		/// Requests the tessellation primitive generator to divide edges into an even number of
		/// equal-length segments plus two additional shorter fractional segments. 
		/// Only valid with one of the tessellation Execution Models.
		/// </summary>
		SpacingFractionalEven = 2,

		/// <summary>
		/// Requests the tessellation primitive generator to divide edges into an odd number of 
		/// equal-length segments plus two additional shorter fractional segments. 
		/// Only valid with one of the tessellation Execution Models.
		/// </summary>
		SpacingFractionalOdd = 3,

		/// <summary>
		/// Requests the tessellation primitive generator to generate triangles in clockwise order.
		/// Only valid with one of the tessellation Execution Models.
		/// </summary>
		VertexOrderCw = 4,

		/// <summary>
		/// Requests the tessellation primitive generator to generate triangles in counter-clockwise order. 
		/// Only valid with one of the tessellation Execution Models.
		/// </summary>
		VertexOrderCcw = 5,

		/// <summary>
		/// Pixels appear centered on whole-number pixel offsets. 
		/// E.g., the coordinate (0.5, 0.5) appears to move to (0.0, 0.0). 
		/// Only valid with the Fragment Execution Model. 
		/// If a Fragment entry point does not have this set, pixels appear centered at 
		/// offsets of (0.5, 0.5) from whole numbers
		/// </summary>
		PixelCenterInteger = 6,

		/// <summary>
		/// Pixel coordinates appear to originate in the upper left, and increase toward the right and downward. 
		/// Only valid with the Fragment Execution Model.
		/// </summary>
		OriginUpperLeft = 7,

		/// <summary>
		/// Pixel coordinates appear to originate in the lower left, and increase toward the right and upward. 
		/// Only valid with the Fragment Execution Model.
		/// </summary>
		OriginLowerLeft = 8,

		/// <summary>
		/// Fragment tests are to be performed before fragment shader execution. 
		/// Only valid with the Fragment Execution Model.
		/// </summary>
		EarlyFragmentTests = 9,

		/// <summary>
		/// Requests the tessellation primitive generator to generate a point for each distinct vertex
		/// in the subdivided primitive, rather than to generate lines or triangles. 
		/// Only valid with one of the tessellation Execution Models.
		/// </summary>
		PointMode = 10,

		/// <summary>
		/// This stage will run in transform feedback-capturing mode and this module is responsible 
		/// for describing the transform-feedback setup. 
		/// See the XfbBuffer, Offset, and XfbStride Decorations.
		/// </summary>
		Xfb = 11,

		/// <summary>
		/// This mode must be declared if this module potentially changes the fragment’s depth.
		/// Only valid with the Fragment Execution Model.
		/// </summary>
		DepthReplacing = 12,

		/// <summary>
		/// External optimizations may assume depth modifications will leave the fragment’s
		/// depth as greater than or equal to the fragment’s interpolated depth value (given
		/// by the z component of the FragCoord BuiltIn decorated variable). 
		/// Only valid with the Fragment Execution Model.
		/// </summary>
		DepthGreater = 14,

		/// <summary>
		/// External optimizations may assume depth modifications leave the fragment’s depth
		/// less than the fragment’s interpolated depth value, (given by the z component of the
		/// FragCoord BuiltIn decorated variable).
		/// Only valid with the Fragment Execution Model.
		/// </summary>
		DepthLess = 15,

		/// <summary>
		/// External optimizations may assume this stage did not modify the fragment’s depth.
		/// However, DepthReplacing mode must accurately represent depth modification.
		/// Only valid with the Fragment Execution Model.
		/// </summary>
		DepthUnchanged = 16,

		/// <summary>
		/// Indicates the work-group size in the x, y, and z dimensions. 
		/// Only valid with the GLCompute or Kernel Execution Models.
		/// 
		/// Extra Operands: [Literal Number] x size, [Literal Number] y size, [Literal Number] z size
		/// </summary>
		LocalSize = 17,

		/// <summary>
		/// A hint to the compiler, which indicates the most likely to be used work-group 
		/// size in the x, y, and z dimensions. 
		/// Only valid with the Kernel Execution Model.
		/// 
		/// Extra Operands: [Literal Number] x size, [Literal Number] y size, [Literal Number] z size
		/// </summary>
		LocalSizeHint = 18,

		/// <summary>
		/// Stage input primitive is points. 
		/// Only valid with the Geometry Execution Model.
		/// </summary>
		InputPoints = 19,

		/// <summary>
		/// Stage input primitive is lines. 
		/// Only valid with the Geometry Execution Model.
		/// </summary>
		InputLines = 20,

		/// <summary>
		/// Stage input primitive is lines adjacency.
		/// Only valid with the Geometry Execution Model.
		/// </summary>
		InputLinesAdjacency = 21,

		/// <summary>
		/// For a geometry stage, input primitive is triangles. 
		/// For a tessellation stage, requests the tessellation primitive generator to generate triangles. 
		/// Only valid with the Geometry or one of the tessellation Execution Models.
		/// </summary>
		Triangles = 22,

		/// <summary>
		/// Geometry stage input primitive is triangles adjacency. 
		/// Only valid with the Geometry Execution Model.
		/// </summary>
		InputTrianglesAdjacency = 23,

		/// <summary>
		/// Requests the tessellation primitive generator to generate quads. 
		/// Only valid with one of the tessellation Execution Models.
		/// </summary>
		Quads = 24,

		/// <summary>
		/// Requests the tessellation primitive generator to generate isolines. 
		/// Only valid with one of the tessellation Execution Models.
		/// </summary>
		Isolines = 25,

		/// <summary>
		/// For a geometry stage, the maximum number of vertices the shader will ever emit in a single invocation. 
		/// For a tessellation-control stage, the number of vertices in the output patch produced by the tessellation 
		/// control shader, which also specifies the number of times the tessellation control shader is invoked. 
		/// Only valid with the Geometry or one of the tessellation Execution Models.
		/// 
		/// Extra Operands: [Literal Number] Vertex count
		/// </summary>
		OutputVertices = 26,

		/// <summary>
		/// Stage output primitive is points. 
		/// Only valid with the Geometry Execution Model.
		/// </summary>
		OutputPoints = 27,

		/// <summary>
		/// Stage output primitive is line strip. 
		/// Only valid with the Geometry Execution Model.
		/// </summary>
		OutputLineStrip = 28,

		/// <summary>
		/// Stage output primitive is triangle strip.
		/// Only valid with the Geometry Execution Model.
		/// </summary>
		OutputTriangleStrip = 29,

		/// <summary>
		/// A hint to the compiler, which indicates that most operations used in the entry point are
		/// explicitly vectorized using a particular vector type.
		/// The 16 high-order bits of Vector Type operand specify the number of components of the vector.
		/// The 16 low-order bits of Vector Type operand specify the data type of the vector.
		/// These are the legal data type values:
		/// 0 represents an 8-bit integer value.
		/// 1 represents a 16-bit integer value.
		/// 2 represents a 32-bit integer value.
		/// 3 represents a 64-bit integer value.
		/// 4 represents a 16-bit float value.
		/// 5 represents a 32-bit float value.
		/// 6 represents a 64-bit float value.
		/// Only valid with the Kernel Execution Model.
		/// 
		/// Extra Operands: [Literal Number] Vector type
		/// </summary>
		VecTypeHint = 30,

		/// <summary>
		/// Indicates that floating-point-expressions contraction is disallowed.
		/// Only valid with the Kernel Execution Model.
		/// </summary>
		ContractionOff = 31
	}
}