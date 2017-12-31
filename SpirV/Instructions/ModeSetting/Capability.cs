using SpirV.Native;

namespace SpirV.Instructions.ModeSetting
{
	/// <summary>
	/// Declare a capability used by this module.
	/// </summary>
	public partial class Capability : BaseInstruction
	{
		public Capability() : this(Native.Capability.Max) { }
		public Capability(Native.Capability capability) {
			CapabilityId = capability;
		}

		public override int WordCount => 2;
		public override Operation OpCode => Operation.Capability;

		/// <summary>
		/// Capability is the capability declared by this instruction.
		/// There are no restrictions on the order in which capabilities are declared.
		/// </summary>
		public Native.Capability CapabilityId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushInt32((int)CapabilityId);
			return byteArray.ToArray();
		}
	}
}
