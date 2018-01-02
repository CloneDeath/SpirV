using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Query the number of samples available per texel fetch in a multisample image.
	/// </summary>
	public class ImageQuerySamples : BaseInstruction
	{
		public override int WordCount => 4;
		public override Operation OpCode => Operation.ImageQuerySamples;
		
		/// <summary>
		/// Result Type must be a scalar integer type.
		/// The result is the number of samples.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Image must be an object whose type is OpTypeImage.
		/// Its Dim operand must be one of 2D and MS of 1.
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
