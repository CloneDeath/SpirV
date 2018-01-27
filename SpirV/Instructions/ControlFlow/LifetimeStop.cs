using SpirV.Native;

namespace SpirV.Instructions.ControlFlow
{
	/// <summary>
	/// Declare that an object is dead after this instruction.
	/// </summary>
	public class LifetimeStop : BaseInstruction {
		public override int WordCount => 3;
		public override Operation OpCode => Operation.LifetimeStop;
		
		/// <summary>
		/// Pointer is a pointer to the object whose lifetime is ending.
		/// Its type must be an OpTypePointer with Storage Class Function.
		/// </summary>
		public int PointerId { get; set; }
		
		/// <summary>
		/// Size must be 0 if Pointer is a pointer to a non-void type or the Addresses capability is not being used.
		/// If Size is non-zero, it is the number of bytes of memory whose lifetime is ending.
		/// Its type must be an integer type scalar.
		/// It is treated as unsigned; if its type has Signedness of 1, its sign bit cannot be set.
		/// </summary>
		public int Size { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(PointerId);
			ba.PushUInt32(Size);
			return ba.ToArray();
		}
	}
}
