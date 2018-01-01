using SpirV.Native;

namespace SpirV.Instructions.Debug
{
	/// <summary>
	/// Assign a Result &lt;id&gt; to a string for use by other debug instructions (see OpLine and OpSource).
	/// This has no semantic impact and can safely be removed from a module.
	/// (Removal also requires removal of all instructions referencing Result &lt;id&gt; .)
	/// </summary>
	public class String : BaseInstruction
	{
		public override int WordCount => 2 + ByteArray.GetWordCount(StringText);
		public override Operation OpCode => Operation.String;

		public int ResultId { get; set; }
		
		/// <summary>
		/// String is the literal string being assigned a Result &lt;id&gt;
		/// </summary>
		public string StringText { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushString(StringText);
			return byteArray.ToArray();
		}
	}
}
