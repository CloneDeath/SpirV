using SpirV.Native;

namespace SpirV.Instructions.Atomic
{
	/// <summary>
	/// Atomically store through Pointer using the given Semantics.
	/// All subparts of Value will be written atomically with respect to all other atomic
	/// accesses to it within Scope.
	/// </summary>
	public class AtomicStore : BaseInstruction {
		public override int WordCount => 5;
		public override Operation OpCode => Operation.AtomicStore;
		
		/// <summary>
		/// Pointer is the pointer to the memory to write.
		/// The type it points to must be a scalar of integer type or floating-point type. 
		/// </summary>
		public int PointerId { get; set; }
		
		public Scope Scope { get; set; }
		
		public MemorySemantics Semantics { get; set; }
		
		/// <summary>
		/// Value is the value to write.
		/// The type of Value and the type pointed to by Pointer must be the same type.
		/// </summary>
		public int ValueId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(PointerId);
			ba.PushUInt32((int)Scope);
			ba.PushUInt32((int)Semantics);
			ba.PushUInt32(ValueId);
			return ba.ToArray();
		}
	}
}
