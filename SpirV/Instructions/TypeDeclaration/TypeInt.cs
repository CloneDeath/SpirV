using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare a new integer type.
	/// </summary>
	public class TypeInt : BaseInstruction
	{
		public TypeInt():this(0, 32, true) { }
		public TypeInt(int resultId, int width, bool signed) {
			ResultId = resultId;
			Width = width;
			Signed = signed;
		}

		public override int WordCount => 4;
		public override Operation OpCode => Operation.TypeInt;

		public int ResultId { get; set; }
		/// <summary>
		/// Width specifies how many bits wide the type is. This literal operand is limited to a single word.
		/// The bit pattern of a signed integer value is two’s complement.
		/// </summary>
		public int Width { get; set; }

		/// <summary>
		/// Signedness specifies whether there are signed semantics to preserve or validate.
		/// 0 indicates unsigned, or no signedness semantics
		/// 1 indicates signed semantics.
		/// In all cases, the type of operation of an instruction comes from the instruction’s opcode, 
		/// not the signedness of the operands.
		/// </summary>
		public bool Signed { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ResultId);
			byteArray.PushUInt32((uint)Width);
			byteArray.PushUInt32(Signed ? 1U : 0U);
			return byteArray.ToArray();
		}
	}
}
