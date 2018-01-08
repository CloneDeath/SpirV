using SpirV.Native;

namespace SpirV.Instructions.Logical
{
	/// <summary>
	/// Select between two objects.
	/// 
	/// Results are computed per component.
	/// </summary>
	public class Select : BaseInstruction {
		public override int WordCount => 6;
		public override Operation OpCode => Operation.Select;
		
		/// <summary>
		/// Result Type must be a scalar or vector.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Condition must be a scalar or vector of Boolean type.
		/// It must have the same number of components as Result Type.
		/// </summary>
		public int ConditionId { get; set; }
		
		/// <summary>
		/// The type of Object 1 must be the same as Result Type.
		/// Object 1 is selected as the result if Condition is true.
		/// </summary>
		public int Object1Id { get; set; }
		
		/// <summary>
		/// The type of Object 2 must be the same as Result Type.
		/// Object 2 is selected as the result if Condition is false.
		/// </summary>
		public int Object2Id { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(ConditionId);
			ba.PushUInt32(Object1Id);
			ba.PushUInt32(Object2Id);
			return ba.ToArray();
		}
	}
}
