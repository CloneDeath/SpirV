namespace Illustrate.Vulkan.SpirV.Instructions
{
	public abstract class SingleResultInstruction : BaseInstruction
	{
		protected SingleResultInstruction() : this(0) { }
		protected SingleResultInstruction(int resultId) {
			ResultId = resultId;
		}

		public override int WordCount => 2;

		public int ResultId { get; set; }

		protected override byte[] GetParameterBytes()
		{
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultId);
			return byteArray.ToArray();
		}
	}
}
