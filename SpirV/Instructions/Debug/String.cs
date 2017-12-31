using System;
using SpirV.Native;

namespace SpirV.Instructions.Debug
{
	public class String : BaseInstruction
	{
		public override int WordCount => 2 + ByteArray.GetWordCount(StringText);
		public override Operation OpCode => Operation.String;

		public int ResultId { get; set; }
		public string StringText { get; set; }

		protected override byte[] GetParameterBytes() {
			throw new NotImplementedException();
		}
	}
}
