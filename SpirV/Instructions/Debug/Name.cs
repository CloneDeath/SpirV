using SpirV.Native;

namespace SpirV.Instructions.Debug
{
	/// <summary>
	/// Assign a name string to another instruction’s Result id. This has no semantic impact and can safely be removed from a module.
	/// </summary>
	public class Name : BaseInstruction
	{
		public Name() : this(0, "") { }
		public Name(int targetId, string targetName) {
			TargetId = targetId;
			TargetName = targetName;
		}

		public override int WordCount => 2 + ByteArray.GetWordCount(TargetName);
		public override Operation OpCode => Operation.Name;

		/// <summary>
		/// Target is the Result id to assign a name to. It can be the Result id of any other instruction; 
		/// a variable, function, type, intermediate result, etc.
		/// </summary>
		public int TargetId { get; set; }

		/// <summary>
		/// Name is the string to assign.
		/// </summary>
		public string TargetName { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)TargetId);
			byteArray.PushString(TargetName);
			return byteArray.ToArray();
		}
	}
}
