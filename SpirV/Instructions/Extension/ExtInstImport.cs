using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.Extension
{
	/// <summary>
	/// Import an extended set of instructions. It can be later referenced by the Result id.
	/// </summary>
	public class ExtInstImport : BaseInstruction
	{
		public ExtInstImport() : this(0, "") { }

		public ExtInstImport(int resultId, string name) {
			ResultId = resultId;
			Name = name;
		}

		public override int WordCount => 2 + ByteArray.GetWordCount(Name);
		public override Operation OpCode => Operation.ExtInstImport;

		public int ResultId { get; set; }
		/// <summary>
		/// Name is the extended instruction-set’s name string. There must be an external specification defining the semantics
		/// for this extended instruction set.
		/// </summary>
		public string Name { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushInt32(ResultId);
			byteArray.PushString(Name);
			return byteArray.ToArray();
		}
	}
}
