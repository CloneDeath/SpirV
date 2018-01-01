namespace SpirV.Native {
	public enum StorageClass
	{
		/// <summary>
		/// Shared externally, visible across all functions in all invocations in all work groups.
		/// Graphics uniform memory. OpenCL constant memory. 
		/// Variables declared with this storage class are read-only, and cannot have initializers.
		/// </summary>
		UniformConstant = 0,

		/// <summary>
		/// Input from pipeline. Visible across all functions in the current invocation. 
		/// Variables declared with this storage class are read-only, and cannot have initializers.
		/// </summary>
		Input = 1,

		/// <summary>
		/// Shared externally, visible across all functions in all invocations in all work groups.
		/// Graphics uniform blocks and buffer blocks.
		/// </summary>
		Uniform = 2,

		/// <summary>
		/// Output to pipeline. Visible across all functions in the current invocation.
		/// </summary>
		Output = 3,

		/// <summary>
		/// Shared across all invocations within a work group.
		/// Visible across all functions. 
		/// The OpenGL "shared" storage qualifier. 
		/// OpenCL local memory.
		/// </summary>
		Workgroup = 4,

		/// <summary>
		/// Visible across all functions of all invocations of all work groups. 
		/// OpenCL global memory.
		/// </summary>
		CrossWorkgroup = 5,

		/// <summary>
		/// Visible to all functions in the current invocation. 
		/// Regular global memory.
		/// </summary>
		Private = 6,

		/// <summary>
		/// Visible only within the declaring function of the current invocation.
		/// Regular function memory.
		/// </summary>
		Function = 7,

		/// <summary>
		/// For generic pointers, which overload the Function, Workgroup, and CrossWorkgroup Storage Classes.
		/// </summary>
		Generic = 8,

		/// <summary>
		/// For holding push-constant memory, visible across all functions in all invocations in all
		/// work groups. Intended to contain a small bank of values pushed from the API.
		/// Variables declared with this storage class are read-only, and cannot have initializers.
		/// </summary>
		PushConstant = 9,

		/// <summary>
		/// For holding atomic counters. Visible across all functions of the current invocation.
		/// Atomic counter-specific memory.
		/// </summary>
		AtomicCounter = 10,

		/// <summary>
		/// For holding image memory.
		/// </summary>
		Image = 11
	}
}