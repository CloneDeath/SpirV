using System;

namespace SpirV.Native {
	[Flags]
	public enum MemoryAccess {
		None = 0,

		/// <summary>
		/// This access cannot be eliminated, duplicated, or combined with other accesses.
		/// </summary>
		Volatile = 1 << 0,

		/// <summary>
		/// This access has a known alignment, provided as a literal in the next operand.
		/// </summary>
		Aligned = 1 << 1,

		/// <summary>
		/// Hints that the accessed address is not likely to be accessed again in the near future.
		/// </summary>
		Nontemporal = 1 << 2
	}
}