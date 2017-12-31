namespace SpirV
{
	public class SpirVModule
	{
		public byte[] Compile(int maxId) {
			var bytes = new ByteArray();

			bytes.PushInt32(MagicNumber);
			bytes.PushUInt32(VulkanVersion);
			bytes.PushUInt32(Generator);
			bytes.PushInt32(maxId);
			bytes.PushUInt32(0);
			foreach (var instruction in Instructions) {
				bytes.Push(instruction.GetBytes());
			}

			return bytes.ToArray();
		}

		protected virtual int MagicNumber => Native.Constants.MagicNumber;
		protected virtual uint VulkanVersion => Native.Constants.Version;
		protected virtual uint Generator => 0;

		public ISpirVInstruction[] Instructions { get; set; } = new ISpirVInstruction[0];
	}
}
