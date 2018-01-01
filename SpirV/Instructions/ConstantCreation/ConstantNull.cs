using SpirV.Native;

namespace SpirV.Instructions.ConstantCreation
{
	/// <summary>
	/// Declare a new null constant value.
	/// The null value is type dependent, defined as follows:
	/// - Scalar Boolean: false
	/// - Scalar integer: 0
	/// - Scalar floating point: +0.0 (all bits 0)
	/// - All other scalars: Abstract
	/// - Composites: Members are set recursively to the null constant according to the null value of their
	/// constituent types.
	/// </summary>
	public class ConstantNull : BaseInstruction {
		public override int WordCount => 3;
		public override Operation OpCode => Operation.ConstantNull;
		
		/// <summary>
		/// Result Type must be one of the following types:
		/// - Scalar or vector Boolean type
		/// - Scalar or vector integer type
		/// - Scalar or vector floating-point type
		/// - Pointer type
		/// - Event type
		/// - Device side event type
		/// - Reservation id type
		/// - Queue type
		/// - Composite type
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint) ResultTypeId);
			byteArray.PushUInt32((uint) ResultId);
			return byteArray.ToArray();
		}
	}
}
