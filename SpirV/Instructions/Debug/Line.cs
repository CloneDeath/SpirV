using System;
using SpirV.Native;

namespace SpirV.Instructions.Debug
{
	/// <summary>
	/// Add source-level location information. This has no semantic impact and can safely be removed from a module.
	/// This location information applies to the instructions physically following this instruction,
	/// up to the first occurrence of any of the following: the next end of block, the next OpLine instruction,
	/// or the next OpNoLine instruction.
	///  
	/// OpLine can generally immediately precede other instructions, with the following exceptions:
	/// - it may not be used until after the annotation instructions, (see the Logical Layout section)
	/// - cannot be the last instruction in a block, which is defined to end with a termination instruction
	/// - if a branch merge instruction is used, the last OpLine in the block must be before its merge instruction
	/// </summary>
	public class Line : BaseInstruction
	{
		public override int WordCount => 4;
		public override Operation OpCode => Operation.Line;

		/// <summary>
		/// File must be an OpString instruction and is the source-level file name.
		/// </summary>
		public int FileId { get; set; }
		
		/// <summary>
		/// Line is the source-level line number. This literal operand is limited to a single word.
		/// </summary>
		public int LineNumber { get; set; }
		
		/// <summary>
		/// Column is the source-level column number. This literal operand is limited to a single word.
		/// </summary>
		public int ColumnNumber { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint) FileId);
			byteArray.PushUInt32((uint) LineNumber);
			byteArray.PushUInt32((uint) ColumnNumber);
			return byteArray.ToArray();
		}
	}
}
