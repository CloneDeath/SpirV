using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.Extension
{
	/// <summary>
	/// Declare use of an extension to SPIR-V. This allows validation of
	/// additional instructions, tokens, semantics, etc.
	/// </summary>
	public class Extension : BaseInstruction
	{
		public Extension() : this("") { }

		public Extension(string name) {
			Name = name;
		}

		public override int WordCount => 1 + ByteArray.GetWordCount(Name);
		public override Operation OpCode => Operation.Extension;

		/// <summary>
		/// Name is the extension’s name string.
		/// </summary>
		public string Name { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushString(Name);
			return byteArray.ToArray();
		}
	}
}
