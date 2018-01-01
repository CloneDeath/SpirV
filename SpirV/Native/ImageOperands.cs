using System;

namespace SpirV.Native {
	[Flags]
	public enum ImageOperands {
		None = 0,

		/// <summary>
		/// A following operand is the bias added to the implicit level of detail. 
		/// Only valid with implicit-lod instructions. 
		/// It must be a floating-point type scalar. 
		/// This can only be used with an OpTypeImage that has a Dim operand of 1D, 2D, 3D, or Cube, and the MS operand must be 0 (Samples.Single).
		/// </summary>
		Bias = 1 << 0,

		/// <summary>
		/// A following operand is the explicit level-of-detail to use. 
		/// Only valid with explicit-lod instructions. 
		/// For sampling operations, it must be a floating-point type scalar. 
		/// For queries and fetch operations, it must be an integer type scalar. 
		/// This can only be used with an OpTypeImage that has a Dim operand of 1D, 2D, 3D, or Cube, and the MS operand must be 0 (Samples.Single).
		/// </summary>
		Lod = 1 << 1,

		/// <summary>
		/// Two following operands are dx followed by dy. 
		/// These are explicit derivatives in the x and y direction to use in computing level of detail. 
		/// Each is a scalar or vector containing (du/dx [,dv/dx] [,dw/dx]) and (du/dy [,dv/dy] [,dw/dy]). 
		/// The number of components of each must equal the number of components in Coordinate, 
		/// minus the array layer component, if present. 
		/// Only valid with explicit-lod instructions. 
		/// They must be a scalar or vector of floating-point type. 
		/// This can only be used with an OpTypeImage that has an MS operand of 0 (Samples.Single). 
		/// It is invalid to set both the Lod and Gradbits.
		/// </summary>
		Grad = 1 << 2,

		/// <summary>
		/// A following operand is added to (u, v, w) before texel lookup. 
		/// It must be an id of an integer-based constant instruction of scalar or vector type. 
		/// It is a compile-time error if these fall outside a target-dependent allowed range. 
		/// The number of components must equal the number of components in Coordinate,
		/// minus the array layer component, if present.
		/// </summary>
		ConstOffset = 1 << 3,

		/// <summary>
		/// A following operand is added to (u, v, w) before texel lookup. 
		/// It must be a scalar or vector of integer type. 
		/// It is a compile-time error if these fall outside a target-dependent allowed range. 
		/// The number of components must equal the number of components in Coordinate, 
		/// minus the array layer component, if present.
		/// </summary>
		Offset = 1 << 4,

		/// <summary>
		/// A following operand is Offsets.
		/// Offsets must be an id of a constant instruction making an array of size four of vectors of two integer components. 
		/// Each gathered texel is identified by adding one of these array elements to the (u, v) sampled location. 
		/// It is a compile-time error if this falls outside a target-dependent allowed range. 
		/// Only valid with OpImageGather or OpImageDrefGather.
		/// </summary>
		ConstOffsets = 1 << 5,

		/// <summary>
		/// A following operand is the sample number of the sample to use. 
		/// Only valid with OpImageFetch, OpImageRead, and OpImageWrite. 
		/// It is invalid to have a Sample operand if the underlying OpTypeImage has MS of 0 (Samples.Single). 
		/// It must be an integer type scalar.
		/// </summary>
		Sample = 1 << 6,

		/// <summary>
		/// A following operand is the minimum level-of-detail to use when accessing the image. 
		/// Only valid with Implicit instructions and Grad instructions. 
		/// It must be a floating-point type scalar. 
		/// This can only be used with an OpTypeImage that has a Dim operand of 1D, 2D, 3D, or Cube, 
		/// and the MS operand must be 0 (Samples.Single).
		/// </summary>
		MinLod = 1 << 7
	}
}