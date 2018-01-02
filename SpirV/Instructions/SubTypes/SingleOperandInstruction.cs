namespace SpirV.Instructions.SubTypes {
	public abstract class SingleOperandInstruction : BaseInstruction {
		public override int WordCount => 4;
		
		public int ResultTypeId { get; set; }
		public int ResultId { get; set; }
		public int OperandId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(OperandId);
			return ba.ToArray();
		}
	}
}