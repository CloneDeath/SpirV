using System;

namespace SpirV.Native {
	/// <summary>
	/// Memory semantics define memory-order constraints, and on what storage classes those constraints apply to.
	/// The memory order constrains the allowed orders in which memory operations in this invocation
	/// can made visible to another invocation.
	/// The storage classes specify to which subsets of memory these constraints are to be applied.
	/// Storage classes not selected are not being constrained.
	/// 
	/// Despite being a mask and allowing multiple bits to be combined,
	/// at most one of the first four (low-order) bits can be set.
	/// Requesting both Acquire and Release semantics is done by setting the AcquireRelease bit,
	/// not by setting two bits.
	/// 
	/// This value is a mask; it can be formed by combining the bits from multiple rows in the table below.
	/// </summary>
	[Flags]
	public enum MemorySemanticsMask {
		None = 0,
		
		/// <summary>
		/// All memory operations provided in program order after this memory operation will execute after
		/// this memory operation.
		/// </summary>
		Acquire = 0x00000002,
		
		/// <summary>
		/// All memory operations provided in program order before this memory operation will execute before
		/// this memory operation.
		/// </summary>
		Release = 0x00000004,
		
		/// <summary>
		/// Has the properties of both Acquire and Release semantics.
		/// It is used for read-modify-write operations.
		/// </summary>
		AcquireRelease = 0x00000008,
		
		/// <summary>
		/// All observers will see this memory access in the same order with respect to other
		/// sequentially-consistent memory accesses from this invocation.
		/// </summary>
		SequentiallyConsistent = 0x00000010,
		
		/// <summary>
		/// Apply the memory-ordering constraints to Uniform Storage Class memory.
		/// </summary>
		UniformMemory = 0x00000040,
		
		/// <summary>
		/// Apply the memory-ordering constraints to subgroup memory.
		/// </summary>
		SubgroupMemory = 0x00000080,
		
		/// <summary>
		/// Apply the memory-ordering constraints to Workgroup Storage Class memory.
		/// </summary>
		WorkgroupMemory = 0x00000100,
		
		/// <summary>
		/// Apply the memory-ordering constraints to CrossWorkgroup Storage Class memory.
		/// </summary>
		CrossWorkgroupMemory = 0x00000200,
		
		/// <summary>
		/// Apply the memory-ordering constraints to AtomicCounter Storage Class memory.
		/// </summary>
		AtomicCounterMemory = 0x00000400,
		
		/// <summary>
		/// Apply the memory-ordering constraints to image contents (types declared by OpTypeImage),
		/// or to accesses done through pointers to the Image Storage Class.
		/// </summary>
		ImageMemory = 0x00000800
	}
}