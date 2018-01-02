using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Query the number of mipmap levels accessible through Image.
	/// </summary>
	public class ImageQueryLevels : BaseInstruction {
		public override int WordCount => 4;
		public override Operation OpCode => Operation.ImageQueryLevels;
		
		/// <summary>
		/// Result Type must be a scalar integer type.
		/// The result is the number of mipmap levels, as defined by the API specification.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Image must be an object whose type is OpTypeImage.
		/// Its Dim operand must be one of 1D, 2D, 3D, or Cube.
		/// </summary>
		public int ImageId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32((uint) ResultTypeId);
			ba.PushUInt32((uint) ResultId);
			ba.PushUInt32((uint) ImageId);
			return ba.ToArray();
		}
	}
}
