using SpirV.Native;

namespace SpirV.Instructions.ModeSetting
{
	/// <summary>
	/// Set addressing model and memory model for the entire module.
	/// </summary>
	public class MemoryModel : BaseInstruction
	{
		public MemoryModel() : this(AddressingModel.Logical, Native.MemoryModel.Simple) { }

		public MemoryModel(AddressingModel addressingModel, Native.MemoryModel memoryMode) {
			AddressingModel = addressingModel;
			MemoryMode = memoryMode;
		}

		public override int WordCount => 3;
		public override Operation OpCode => Operation.MemoryModel;

		/// <summary>
		/// Addressing Model selects the module’s Addressing Model.
		/// </summary>
		public AddressingModel AddressingModel { get; set; }

		/// <summary>
		/// Memory Model selects the module’s memory model.
		/// </summary>
		public Native.MemoryModel MemoryMode { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)AddressingModel);
			byteArray.PushUInt32((uint)MemoryMode);
			return byteArray.ToArray();
		}
	}
}
