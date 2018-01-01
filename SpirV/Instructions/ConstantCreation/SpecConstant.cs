using SpirV.Native;

namespace SpirV.Instructions.ConstantCreation
{
	/// <summary>
	/// Declare a new integer-type or floating-point-type scalar specialization constant.
	/// This instruction can be specialized to become an OpConstant instruction.
	/// </summary>
	public class SpecConstant : BaseInstruction {
		public override int WordCount => 3 + Values.Length;
		public override Operation OpCode => Operation.SpecConstant;
		
		/// <summary>
		/// Result Type must be a scalar integer type or floating-point type.
		/// </summary>
		public int ResultTypeId { get; set; }
		public int ResultId { get; set; }
		
		/// <summary>
		/// Value is the bit pattern for the default value of the constant.
		/// Types 32 bits wide or smaller take one word.
		/// Larger types take multiple words, with low-order words appearing first.
		/// </summary>
		public uint[] Values { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint) ResultTypeId);
			byteArray.PushUInt32((uint) ResultId);
			foreach (var value in Values) {
				byteArray.PushUInt32(value);
			}
			return byteArray.ToArray();
		}
	}
}
