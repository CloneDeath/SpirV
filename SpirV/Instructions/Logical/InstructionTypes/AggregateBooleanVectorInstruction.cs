namespace SpirV.Instructions.Logical.InstructionTypes {
	public abstract class AggregateBooleanVectorInstruction : BaseInstruction {
		public override int WordCount => 4;
		
		/// <summary>
		/// Result Type must be a Boolean type scalar. 
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Vector must be a vector of Boolean type.
		/// </summary>
		public int VectorId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(VectorId);
			return ba.ToArray();
		}
	}
}