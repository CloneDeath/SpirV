using SpirV.Native;

namespace SpirV.Instructions.Debug
{
	/// <summary>
	/// Continue specifying the Source text from the previous instruction.
	/// This has no semantic impact and can safely be removed from a module.
	/// 
	/// The previous instruction must be an OpSource or an OpSourceContinued instruction.
	/// As is true for all literal strings, the previous instruction’s string was nul terminated. 
	/// That terminating 0 word from the previous instruction is not part of the source text; 
	/// the first character of Continued Source logically immediately follows the last character of Source before its nul.
	/// </summary>
	public class SourceContinued : BaseInstruction
	{
		public SourceContinued() : this("") { }
		public SourceContinued(string continuedSource) {
			ContinuedSource = continuedSource;
		}

		public override int WordCount => 1 + ByteArray.GetWordCount(ContinuedSource);
		public override Operation OpCode => Operation.SourceContinued;

		/// <summary>
		/// Continued Source is a continuation of the source text in the previous Source.
		/// </summary>
		public string ContinuedSource { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushString(ContinuedSource);
			return byteArray.ToArray();
		}
	}
}
