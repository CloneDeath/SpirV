using SpirV.Native;

namespace SpirV.Instructions.Memory
{
	/// <summary>
	/// Copy from the memory pointed to by Source to the memory pointed to by Target.
	/// Both operands must be non-void pointers of the same type.
	/// Matching Storage Class is not required.
	/// The amount of memory copied is the size of the type pointed to.
	/// </summary>
	public class CopyMemory : BaseInstruction {
		public override int WordCount => 3 + (MemoryAccess != null ? 1 : 0);
		public override Operation OpCode => Operation.CopyMemory;
		
		public int TargetId { get; set; }
		public int SourceId { get; set; }
		
		/// <summary>
		/// Memory Access must be a Memory Access literal.
		/// If not present, it is the same as specifying None.
		/// </summary>
		public MemoryAccess? MemoryAccess { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint) TargetId);
			byteArray.PushUInt32((uint) SourceId);
			if (MemoryAccess != null) {
				byteArray.PushUInt32((uint) MemoryAccess);	
			}
			return byteArray.ToArray();
		}
	}
}
