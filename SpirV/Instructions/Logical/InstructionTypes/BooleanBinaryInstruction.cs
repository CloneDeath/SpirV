namespace SpirV.Instructions.Logical.InstructionTypes {
	public abstract class BooleanBinaryInstruction : BaseInstruction {
		public override int WordCount => 5;
		
		/// <summary>
		/// Result Type must be a scalar or vector of Boolean type.
		/// Results are computed per component.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// The type of Operand 1 must be the same as Result Type.
		/// </summary>
		public int Operand1Id { get; set; }
		
		/// <summary>
		/// The type of Operand 2 must be the same as Result Type. 
		/// </summary>
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