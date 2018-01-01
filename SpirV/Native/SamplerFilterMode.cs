namespace SpirV.Native {
	/// <summary>
	/// Filter mode for creating constant samplers. Used by OpConstantSampler.
	/// </summary>
	public enum SamplerFilterMode {
		/// <summary>
		/// Use filter nearest mode when performing a read image operation.
		/// </summary>
		Nearest = 0,
		
		/// <summary>
		/// Use filter linear mode when performing a read image operation.
		/// </summary>
		Linear = 1,
		
		Max = 0x7fffffff
	}
}