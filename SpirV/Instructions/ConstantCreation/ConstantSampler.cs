using SpirV.Native;

namespace SpirV.Instructions.ConstantCreation
{
	/// <summary>
	/// Declare a new sampler constant.
	/// </summary>
	public class ConstantSampler : BaseInstruction {
		public override int WordCount => 6;
		public override Operation OpCode => Operation.ConstantSampler;
		
		/// <summary>
		/// Result Type must be OpTypeSampler.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Sampler Addressing Mode is the addressing mode; a literal from Sampler Addressing Mode.
		/// </summary>
		public SamplerAddressingMode SamplerAddressingMode { get; set; }
		
		public Normalized Normalized { get; set; }
		
		/// <summary>
		/// Sampler Filter Mode is the filter mode; a literal from Sampler Filter Mode.
		/// </summary>
		public SamplerFilterMode SamplerFilterMode { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint) ResultTypeId);
			byteArray.PushUInt32((uint) ResultId);
			byteArray.PushUInt32((uint) SamplerAddressingMode);
			byteArray.PushUInt32((uint) Normalized);
			byteArray.PushUInt32((uint) SamplerFilterMode);
			return byteArray.ToArray();
		}
	}

	public enum Normalized {
		NonNormalized = 0,
		Normalized = 1
	}
}
