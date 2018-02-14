using SpirV.Native;

namespace SpirV.Instructions.Atomic
{
	/// <summary>
	/// Perform the following steps atomically with respect to any other atomic accesses within
	/// Scope to the same location:
	/// 1) load through Pointer to get an Original Value,
	/// 2) get a New Value by selecting Value if Original Value equals Comparator
	/// or selecting Original Value otherwise, and
	/// 3) store the New Value back through Pointer.
	/// 
	/// The instruction’s result is the Original Value.
	/// </summary>
	public class AtomicCompareExchange : BaseInstruction {
		public override int WordCount => 9;
		public override Operation OpCode => Operation.AtomicCompareExchange;
		
		/// <summary>
		/// Result Type must be an integer type scalar
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		public int PointerId { get; set; }
		
		public Scope Scope { get; set; }
		
		/// <summary>
		/// Use Equal for the memory semantics of this instruction when Value and Original Value compare equal.
		/// </summary>
		public MemorySemantics Equal { get; set; }
		
		/// <summary>
		/// Use Unequal for the memory semantics of this instruction when Value and Original Value compare unequal.
		/// Unequal cannot be set to Release or Acquire and Release.
		/// In addition, Unequal cannot be set to a stronger memory-order then Equal.
		/// </summary>
		public MemorySemantics Unequal { get; set; }
		
		/// <summary>
		/// The type of Value must be the same as Result Type.
		/// The type of the value pointed to by Pointer must be the same as Result Type.
		/// This type must also match the type of Comparator.
		/// </summary>
		public int ValueId { get; set; }
		
		public int ComparatorId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(PointerId);
			ba.PushUInt32((int)Scope);
			ba.PushUInt32((int)Equal);
			ba.PushUInt32((int)Unequal);
			ba.PushUInt32(ValueId);
			ba.PushUInt32(ComparatorId);
			return ba.ToArray();
		}
	}
}
