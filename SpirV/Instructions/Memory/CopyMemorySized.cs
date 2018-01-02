using SpirV.Native;

namespace SpirV.Instructions.Memory
{
	/// <summary>
	/// Copy from the memory pointed to by Source to the memory pointed to by Target.
	/// </summary>
	public class CopyMemorySized : BaseInstruction {
		public override int WordCount => 4 + (MemoryAccess != null ? 1 : 0);
		public override Operation OpCode => Operation.CopyMemorySized;
		
		public int TargetId { get; set; }
		
		public int SourceId { get; set; }
		
		/// <summary>
		/// Size is the number of bytes to copy.
		/// It must have a scalar integer type.
		/// If it is a constant instruction, the constant value cannot be 0.
		/// It is invalid for both the constant’s type to have Signedness of 1 and to have the sign bit set.
		/// Otherwise, as a run-time value, Size is treated as unsigned,
		/// and if its value is 0, no memory access will be made.
		/// </summary>
		public int SizeId { get; set; }
		
		/// <summary>
		/// Memory Access must be a Memory Access literal.
		/// If not present, it is the same as specifying None.
		/// </summary>
		public MemoryAccess? MemoryAccess { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint) TargetId);
			byteArray.PushUInt32((uint) SourceId);
			byteArray.PushUInt32((uint) SizeId);
			if (MemoryAccess != null) {
				byteArray.PushUInt32((uint) MemoryAccess);
			}
			return byteArray.ToArray();
		}
	}
}
