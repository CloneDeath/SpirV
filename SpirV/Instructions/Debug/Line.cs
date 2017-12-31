using System;
using SpirV.Native;

namespace SpirV.Instructions.Debug
{
	public class Line : BaseInstruction
	{
		public override int WordCount => 4;
		public override Operation OpCode => Operation.Line;

		public int FileId { get; set; }
		public int LineNumber { get; set; }
		public int ColumnNumber { get; set; }

		protected override byte[] GetParameterBytes() {
			throw new NotImplementedException();
		}
	}
}
