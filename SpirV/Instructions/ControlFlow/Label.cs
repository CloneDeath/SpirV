using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.ControlFlow
{
	/// <summary>
	/// The block label instruction: Any reference to a block is through the Result id of its label.
	/// Must be the first instruction of any block, and appears only as the first instruction of a block.
	/// </summary>
	public class Label : SingleResultInstruction
	{
		public Label(int resultId) : base(resultId) { }
		public override Operation OpCode => Operation.Label;
	}
}
