using SpirV.Native;

namespace SpirV.Instructions.Memory
{
	/// <summary>
	/// Form a pointer to a texel of an image. Use of such a pointer is limited to atomic operations.
	/// </summary>
	public class ImageTexelPointer : BaseInstruction {
		public override int WordCount => 6;
		public override Operation OpCode => Operation.ImageTexelPointer;
		
		/// <summary>
		/// Result Type must be an OpTypePointer whose Storage Class operand is Image.
		/// Its Type operand must be a scalar numerical type or OpTypeVoid.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Image must have a type of OpTypePointer with Type OpTypeImage.
		/// The Sampled Type of the type of Image must be the same as the Type pointed to by Result Type.
		/// The Dim operand of Type cannot be SubpassData.
		/// </summary>
		public int ImageId { get; set; }
		
		/// <summary>
		/// Coordinate and Sample specify which texel and sample within the image to form a pointer to.
		/// 
		/// Coordinate must be a scalar or vector of integer type.
		/// It must have the number of components specified below, given the following Arrayed and Dim
		/// operands of the type of the OpTypeImage.
		/// 
		/// If Arrayed is 0:
		/// 1D: scalar
		/// 2D: 2 components
		/// 3D: 3 components
		/// Cube: 3 components
		/// Rect: 2 components
		/// Buffer: scalar
		/// 
		/// If Arrayed is 1:
		/// 1D: 2 components
		/// 2D: 3 components
		/// Cube: 3 components; the face and layer combine into the 3rd component, layer_face, such that face is
		/// layer_face % 6 and layer is floor(layer_face / 6)
		/// </summary>
		public int CoordinateId { get; set; }
		
		/// <summary>
		/// Coordinate and Sample specify which texel and sample within the image to form a pointer to.
		/// 
		/// Sample must be an integer type scalar.
		/// It specifies which sample to select at the given coordinate.
		/// It must be a valid &lt;id&gt; for the value 0 if the OpTypeImage has MS of 0.
		/// </summary>
		public int SampleId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint) ResultTypeId);
			byteArray.PushUInt32((uint) ResultId);
			byteArray.PushUInt32((uint) ImageId);
			byteArray.PushUInt32((uint) CoordinateId);
			byteArray.PushUInt32((uint) SampleId);
			return byteArray.ToArray();
		}
	}
}
