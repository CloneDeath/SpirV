using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Query the mipmap level and the level of detail for a hypothetical sampling of Image at Coordinate
	/// using an implicit level of detail.
	/// 
	/// If called on an incomplete image, the results are undefined.
	/// 
	/// This instruction is only valid in the Fragment Execution Model.
	/// In addition, it consumes an implicit derivative that can be affected by code motion.
	/// </summary>
	public class ImageQueryLod : BaseInstruction {
		public override int WordCount => 5;
		public override Operation OpCode => Operation.ImageQueryLod;
		
		/// <summary>
		/// Result Type must be a two-component floating-point type vector.
		/// The first component of the result will contain the mipmap array layer.
		/// The second component of the result will contain the implicit level of detail relative to the base level.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Sampled Image must be an object whose type is OpTypeSampledImage.
		/// Its Dim operand must be one of 1D, 2D, 3D, or Cube.
		/// </summary>
		public int SampledImageId { get; set; }
		
		/// <summary>
		/// Coordinate must be a scalar or vector of floating-point type or integer type.
		/// It contains (u[, v] … ) as needed by the definition of Sampled Image, not including any
		/// array layer index. Unless the Kernel capability is being used, it must be floating point.
		/// </summary>
		public int CoordinateId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32((uint) ResultTypeId);
			ba.PushUInt32((uint) ResultId);
			ba.PushUInt32((uint) SampledImageId);
			ba.PushUInt32((uint) CoordinateId);
			return ba.ToArray();
		}
	}
}
