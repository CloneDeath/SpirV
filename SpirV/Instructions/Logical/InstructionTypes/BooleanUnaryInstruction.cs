namespace SpirV.Instructions.Logical.InstructionTypes {
	public abstract class BooleanUnaryInstruction : BaseInstruction {
		public override int WordCount => 4;
		
		/// <summary>
		/// Result Type must be a scalar or vector of Boolean type.
		/// Results are computed per component.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// The type of Operand must be the same as Result Type. 
		/// </summary>
		public int ValueId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(ValueId);
			return ba.ToArray();
		}
	}
}