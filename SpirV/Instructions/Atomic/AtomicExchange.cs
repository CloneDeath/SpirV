using SpirV.Native;

namespace SpirV.Instructions.Atomic
{
	/// <summary>
	/// Perform the following steps atomically with respect to any other atomic accesses within
	/// Scope to the same location:
	/// 1) load through Pointer to get an Original Value,
	/// 2) get a New Value from copying Value, and
	/// 3) store the New Value back through Pointer.
	/// 
	/// The instruction’s result is the Original Value.
	/// </summary>
	public class AtomicExchange : BaseInstruction {
		public override int WordCount => 7;
		public override Operation OpCode => Operation.AtomicExchange;
		
		/// <summary>
		/// Result Type must be a scalar of integer type or floating-point type. 
		/// </summary>
		public int ResultTypeId { get; set; }
		public int ResultId { get; set; }
		public int PointerId { get; set; }
		public Scope Scope { get; set; }
		public MemorySemanticsMask MemorySemantics { get; set; }
		
		/// <summary>
		/// The type of Value must be the same as Result Type.
		/// The type of the value pointed to by Pointer must be the same as Result Type.
		/// </summary>
		public int ValueId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(PointerId);
			ba.PushUInt32((int)Scope);
			ba.PushUInt32((int)MemorySemantics);
			ba.PushUInt32(ValueId);
			return ba.ToArray();
		}
	}
}
