using SpirV.Native;

namespace SpirV.Instructions.Debug
{
	/// <summary>
	/// Document an extension to the source language. This has no semantic impact and can safely be removed from a module.
	/// </summary>
	public class SourceExtension : BaseInstruction
	{
		public SourceExtension() : this("") { }
		public SourceExtension(string extension) {
			Extension = extension;
		}
		public override int WordCount => 1 + ByteArray.GetWordCount(Extension);
		public override Operation OpCode => Operation.SourceExtension;

		/// <summary>
		/// Extension is a string describing a source-language extension.Its form is dependent on the how the
		/// source language describes extensions.
		/// </summary>
		public string Extension { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushString(Extension);
			return byteArray.ToArray();
		}
	}
}
