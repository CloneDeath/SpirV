using SpirV.Native;

namespace SpirV.Instructions.Debug
{
	/// <summary>
	/// Document what source language and text this module was translated from. 
	/// This has no semantic impact and can safely be removed from a module.
	/// </summary>
	public class Source : BaseInstruction
	{
		public Source(SourceLanguage language, int version, int? fileId = null, string sourceText = null) {
			SourceLanguage = language;
			Version = version;
			FileId = fileId;
			SourceText = sourceText;
		}

		public override int WordCount => 3 + (FileIdIsValid ? 1 : 0) + (SourceTextIsValid ? ByteArray.GetWordCount(SourceText) : 0);
		public override Operation OpCode => Operation.Source;

		public SourceLanguage SourceLanguage { get; set; }

		/// <summary>
		/// Version is the version of the source language.This literal operand is limited to a single word.
		/// </summary>
		public int Version { get; set; }

		/// <summary>
		/// File is an OpString instruction and is the source-level file name.
		/// </summary>
		public int? FileId { get; set; }

		/// <summary>
		/// Source is the text of the source-level file.
		/// </summary>
		public string SourceText { get; set; }

		protected bool FileIdIsValid => FileId != null || SourceTextIsValid;
		protected bool SourceTextIsValid => !string.IsNullOrEmpty(SourceText);

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)SourceLanguage);
			byteArray.PushInt32(Version);
			if (FileIdIsValid) {
				byteArray.PushUInt32((uint)FileId);
				if (SourceTextIsValid) {
					byteArray.PushString(SourceText);
				}
			}
			return byteArray.ToArray();
		}
	}
}
