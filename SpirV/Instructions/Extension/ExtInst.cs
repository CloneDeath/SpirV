using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.Extension
{
	/// <summary>
	/// Execute an instruction in an imported set of extended instructions.
	/// </summary>
	public class ExtInst : BaseInstruction
	{
		public override int WordCount => 5 + Operands.Length;
		public override Operation OpCode => Operation.ExtInst;

		/// <summary>
		/// Result Type is as defined, per Instruction, in the external specification for Set.
		/// </summary>
		public int ResultType { get; set; }

		public int ResultId { get; set; }

		/// <summary>
		/// Set is the result of an OpExtInstImport instruction.
		/// </summary>
		public int Set { get; set; }

		/// <summary>
		/// Instruction is the enumerant of the instruction to execute within Set. This literal operand is limited to a single word.
		/// The semantics of the instruction must be defined in the external specification for Set.
		/// </summary>
		public int Instruction { get; set; }

		/// <summary>
		/// Operand 1,... are the operands to the extended instruction.
		/// </summary>
		public int[] Operands { get; set; } = new int[0];

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushInt32(ResultType);
			byteArray.PushInt32(ResultId);
			byteArray.PushInt32(Set);
			byteArray.PushInt32(Instruction);
			foreach (var operand in Operands) {
				byteArray.PushInt32(operand);
			}
			return byteArray.ToArray();
		}
	}
}
