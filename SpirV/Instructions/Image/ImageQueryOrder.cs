﻿using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Query the channel order of an image created with an Unknown Image Format.
	/// </summary>
	public class ImageQueryOrder : BaseInstruction {
		public override int WordCount => 4;
		public override Operation OpCode => Operation.ImageQueryOrder;
		
		/// <summary>
		/// Result Type must be a scalar integer type.
		/// The resulting value is an enumerant from Image Channel Order.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Image must be an object whose type is OpTypeImage.
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
