namespace SpirV.Instructions.Derivative.Common {
	public abstract class DerivativeInstruction : BaseInstruction {
		public override int WordCount => 4;
		
		/// <summary>
		/// Result Type must be a scalar or vector of floating-point type. 
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// The type of P must be the same as Result Type.
		/// P is the value to take the derivative of.
		/// </summary>
		public int PId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(PId);
			return ba.ToArray();
		}
	}
}