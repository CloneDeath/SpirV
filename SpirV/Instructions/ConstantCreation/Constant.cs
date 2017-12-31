using System;
using System.Linq;
using Illustrate.Vulkan.SpirV.Native;

namespace Illustrate.Vulkan.SpirV.Instructions.ConstantCreation
{
	/// <summary>
	/// Declare a new integer-type or floating-point-type scalar constant.
	/// </summary>
	public class Constant : BaseInstruction
	{
	    public Constant(int resultTypeId, int resultId, params float[] value)
	            : this(resultTypeId, resultId,
	                   value.Select(BitConverter.GetBytes)
                            .Select(b => BitConverter.ToInt32(b, 0)).ToArray())
        { }
		public Constant(int resultTypeId, int resultId, params int[] value) {
			ResultTypeId = resultTypeId;
			ResultId = resultId;
			Value = value;
		}

		public override int WordCount => 3 + Value.Length;
		public override Operation OpCode => Operation.Constant;

		/// <summary>
		/// Result Type must be a scalar integer type or floating-point type.
		/// </summary>
		public int ResultTypeId { get; set; }
		public int ResultId { get; set; }

		/// <summary>
		/// Value is the bit pattern for the constant.
		/// Types 32 bits wide or smaller take one word.
		/// Larger types take multiple words, with low-order words appearing first.
		/// </summary>
		public int[] Value { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultTypeId);
			byteArray.PushUInt32((uint)ResultId);
			foreach (var value in Value) {
				byteArray.PushUInt32((uint)value);
			}
			return byteArray.ToArray();
		}
	}
}
