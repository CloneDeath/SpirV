namespace SpirV.Native {
	public enum BuiltIn {
		/// <summary>
		/// Output vertex position from a vertex processing Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		Position = 0,

		/// <summary>
		/// Output point size from a vertex processing Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		PointSize = 1,

		/// <summary>
		/// Array of clip distances. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		ClipDistance = 3,

		/// <summary>
		/// Array of clip distances. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		CullDistance = 4,

		/// <summary>
		/// Input vertex ID to a Vertex Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		VertexId = 5,

		/// <summary>
		/// Input instance ID to a Vertex Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		InstanceId = 6,

		/// <summary>
		/// Primitive ID in a Geometry Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		PrimitiveId = 7,

		/// <summary>
		/// Invocation ID, input to Geometry and TessellationControl Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		InvocationId = 8,

		/// <summary>
		/// Layer output by a Geometry Execution Model, input to a Fragment Execution Model, for multi-layer framebuffer. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		Layer = 9,

		/// <summary>
		/// Viewport Index output by a Geometry stage, input to a Fragment Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		ViewportIndex = 10,

		/// <summary>
		/// Output patch outer levels in a TessellationControl Execution Model. 
		/// See Vulkan or OpenGL API specifications formore detail.
		/// </summary>
		TessLevelOuter = 11,

		/// <summary>
		/// Output patch inner levels in a TessellationControl Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		TessLevelInner = 12,

		/// <summary>
		/// Input vertex position in TessellationEvaluation Execution Model.
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		TessCoord = 13,

		/// <summary>
		/// Input patch vertex count in a tessellation Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		PatchVertices = 14,

		/// <summary>
		/// Coordinates (x, y, z, 1/w) of the current fragment, input to the Fragment Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		FragCoord = 15,

		/// <summary>
		/// Coordinates within a point, input to the Fragment Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		PointCoord = 16,

		/// <summary>
		/// Face direction, input to the Fragment Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		FrontFacing = 17,

		/// <summary>
		/// Input sample number to the Fragment Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		SampleId = 18,

		/// <summary>
		/// Input sample position to the Fragment Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		SamplePosition = 19,

		/// <summary>
		/// Input or output sample mask to the Fragment Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		SampleMask = 20,

		/// <summary>
		/// Output fragment depth from the Fragment Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		FragDepth = 22,

		/// <summary>
		/// Input whether a helper invocation, to the Fragment Execution Model. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		HelperInvocation = 23,

		/// <summary>
		/// Number of workgroups in GLCompute or Kernel Execution Models. 
		/// See OpenCL, Vulkan, or OpenGL API specifications for more detail.
		/// </summary>
		NumWorkgroups = 24,

		/// <summary>
		/// Work-group size in GLCompute or Kernel Execution Models. 
		/// See OpenCL, Vulkan, or OpenGL API specifications for more detail.
		/// </summary>
		WorkgroupSize = 25,

		/// <summary>
		/// Work-group ID in GLCompute or Kernel Execution Models. 
		/// See OpenCL, Vulkan, or OpenGL API specifications for more detail.
		/// </summary>
		WorkgroupId = 26,

		/// <summary>
		/// Local invocation ID in GLCompute or Kernel Execution Models. 
		/// See OpenCL, Vulkan, or OpenGL API specifications for more detail.
		/// </summary>
		LocalInvocationId = 27,

		/// <summary>
		/// Global invocation ID in GLCompute or Kernel Execution Models. 
		/// See OpenCL, Vulkan, or OpenGL API specifications for more detail.
		/// </summary>
		GlobalInvocationId = 28,

		/// <summary>
		/// Local invocation index in GLCompute Execution Models. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// 
		/// Work-group Linear ID in Kernel Execution Models. 
		/// See OpenCL API specification for more detail.
		/// </summary>
		LocalInvocationIndex = 29,

		/// <summary>
		/// Work dimensions in Kernel Execution Models. 
		/// See OpenCL API specification for more detail.
		/// </summary>
		WorkDim = 30,

		/// <summary>
		/// Global size in Kernel Execution Models. 
		/// See OpenCL API specification for more detail.
		/// </summary>
		GlobalSize = 31,

		/// <summary>
		/// Enqueued work-group size in Kernel Execution Models. 
		/// See OpenCL API specification for more detail.
		/// </summary>
		EnqueuedWorkgroupSize = 32,

		/// <summary>
		/// Global offset in Kernel Execution Models.
		/// See OpenCL API specification for more detail.
		/// </summary>
		GlobalOffset = 33,

		/// <summary>
		/// Global linear ID in Kernel Execution Models. 
		/// See OpenCL API specification for more detail.
		/// </summary>
		GlobalLinearId = 34,

		/// <summary>
		/// Subgroup size in Kernel Execution Models.
		/// See OpenCL API specification for more detail.
		/// </summary>
		SubgroupSize = 36,

		/// <summary>
		/// Subgroup maximum size in Kernel Execution Models. 
		/// See OpenCL API specification for more detail.
		/// </summary>
		SubgroupMaxSize = 37,

		/// <summary>
		/// Number of subgroups in Kernel Execution Models. 
		/// See OpenCL API specification for more detail.
		/// </summary>
		NumSubgroups = 38,

		/// <summary>
		/// Number of enqueued subgroups in Kernel Execution Models. 
		/// See OpenCL API specification for more detail.
		/// </summary>
		NumEnqueuedSubgroups = 39,

		/// <summary>
		/// Subgroup ID in Kernel Execution Models.
		/// See OpenCL API specification for more detail.
		/// </summary>
		SubgroupId = 40,

		/// <summary>
		/// Subgroup local invocation ID in Kernel Execution Models. 
		/// See OpenCL API specification for more detail.
		/// </summary>
		SubgroupLocalInvocationId = 41,

		/// <summary>
		/// Vertex index. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		VertexIndex = 42,

		/// <summary>
		/// Instance index. 
		/// See Vulkan or OpenGL API specifications for more detail.
		/// </summary>
		InstanceIndex = 43,


		Max = 0x7fffffff
	}
}