namespace SpirV.Instructions.ModeSetting
{
	public partial class Capability
	{
		public static readonly Capability Matrix = new Capability(Native.Capability.Matrix);
		public static readonly Capability Shader = new Capability(Native.Capability.Shader);
	}
}
