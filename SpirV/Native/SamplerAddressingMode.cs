namespace SpirV.Native {
	/// <summary>
	/// Addressing mode for creating constant samplers. Used by OpConstantSampler.
	/// </summary>
	public enum SamplerAddressingMode {
		/// <summary>
		/// The image coordinates used to sample elements of the image refer to a location inside the image,
		/// otherwise the results are undefined.
		/// </summary>
		None = 0,
		
		/// <summary>
		/// Out-of-range image coordinates are clamped to the extent.
		/// </summary>
		ClampToEdge = 1,
		
		/// <summary>
		/// Out-of-range image coordinates will return a border color.
		/// </summary>
		Clamp = 2,
		
		/// <summary>
		/// Out-of-range image coordinates are wrapped to the valid range.
		/// Can only be used with normalized coordinates.
		/// </summary>
		Repeat = 3,
		
		/// <summary>
		/// Flip the image coordinate at every integer junction.
		/// Can only be used with normalized coordinates.
		/// </summary>
		RepeatMirrored = 4,
		
		Max = 0x7fffffff
	}
}