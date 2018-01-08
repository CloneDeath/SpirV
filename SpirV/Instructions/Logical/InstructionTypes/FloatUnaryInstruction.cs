namespace SpirV.Instructions.Logical.InstructionTypes {
	public abstract class FloatUnaryInstruction : BaseInstruction {
		public override int WordCount => 4;
		
		/// <summary>
		/// Result Type must be a scalar or vector of Boolean type. 
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// x must be a scalar or vector of floating-point type.
		/// It must have the same number of components as Result Type.
		/// Results are computed per component.
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