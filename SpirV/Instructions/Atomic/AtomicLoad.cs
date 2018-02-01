using SpirV.Native;

namespace SpirV.Instructions.Atomic
{
	/// <summary>
	/// Atomically load through Pointer using the given Semantics.
	/// All subparts of the value that is loaded will be read atomically with respect to all other
	/// atomic accesses to it within Scope.
	/// </summary>
	public class AtomicLoad : BaseInstruction {
		public override int WordCount => 6;
		public override Operation OpCode => Operation.AtomicLoad;
		
		/// <summary>
		/// Result Type must be a scalar of integer type or floating-point type.
		/// </summary>
		public int ResultTypeId { get; set; }
		public int ResultId { get; set; }
		
		/// <summary>
		/// Pointer is the pointer to the memory to read.
		/// The type of the value pointed to by Pointer must be the same as Result Type.
		/// </summary>
		public int PointerId { get; set; }
		public Scope Scope { get; set; }
		public MemorySemanticsMask MemorySemantics { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(PointerId);
			ba.PushUInt32((int)Scope);
			ba.PushUInt32((int) MemorySemantics);
			return ba.ToArray();
		}
	}
}
