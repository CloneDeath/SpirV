using System;
using SpirV.Native;

namespace SpirV.Instructions.Debug
{
	public class NoLine : BaseInstruction
	{
		public override int WordCount => 1;
		public override Operation OpCode => Operation.NoLine;

		protected override byte[] GetParameterBytes() {
			throw new NotImplementedException();
		}
	}
}
