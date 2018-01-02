﻿using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Instruction reserved for future use. Use of this instruction is invalid.
	/// </summary>
	public class ImageSparseSampleProjDrefImplicitLod : BaseInstruction
	{
		public override int WordCount => 6 + (ImageOperands != null ? 1 : 0) + Ids.Length;
		public override Operation OpCode => Operation.ImageSparseSampleProjDrefImplicitLod;
		
		public int ResultTypeId { get; set; }
		public int ResultId { get; set; }
		public int SampledImageId { get; set; }
		public int CoordinateId { get; set; }
		public int DrefId { get; set; }
		public ImageOperands? ImageOperands { get; set; }
		public int[] Ids { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(SampledImageId);
			ba.PushUInt32(CoordinateId);
			ba.PushUInt32(DrefId);
			if (ImageOperands != null) ba.PushUInt32((uint) ImageOperands);
			ba.PushUInt32(Ids);
			return ba.ToArray();
		}
	}
}
