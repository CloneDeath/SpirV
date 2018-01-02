namespace SpirV.Instructions.Arithmetic.SubTypes {
	public abstract class TwoOperandInstruction : BaseInstruction {
		public override int WordCount => 5;
		
		public int ResultTypeId { get; set; }
		public int ResultId { get; set; }
		public int Operand1Id { get; set; }
		public int Operand2Id { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(Operand1Id);
			ba.PushUInt32(Operand2Id);
			return ba.ToArray();
		}
	}
}