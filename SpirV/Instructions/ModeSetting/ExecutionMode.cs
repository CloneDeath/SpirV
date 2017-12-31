using SpirV.Native;

namespace SpirV.Instructions.ModeSetting
{
	/// <summary>
	/// Declare an execution mode for an entry point.
	/// </summary>
	public class ExecutionMode : BaseInstruction
	{
		public ExecutionMode(int entryPoint, Native.ExecutionMode mode, params int[] literals) {
			EntryPoint = entryPoint;
			Mode = mode;
			Literals = literals;
		}

		public override int WordCount => 3 + Literals.Length;
		public override Operation OpCode => Operation.ExecutionMode;

		/// <summary>
		/// Entry Point must be the Entry Point id operand of an OpEntryPoint instruction.
		/// </summary>
		public int EntryPoint { get; set; }

		/// <summary>
		/// Mode is the execution mode.
		/// </summary>
		public Native.ExecutionMode Mode { get; set; }
		public int[] Literals { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)EntryPoint);
			byteArray.PushUInt32((uint)Mode);
			foreach (var literal in Literals) {
				byteArray.PushInt32(literal);
			}
			return byteArray.ToArray();
		}
	}
}
