using SpirV.Native;

namespace SpirV.Instructions.Bit
{
	/// <summary>
	/// Shift the bits in Base left by the number of bits specified in Shift.
	/// The least-significant bits will be zero filled.
	/// 
	/// The number of components and bit width of Result Type must match those Base type.
	/// All types must be integer types.
	/// 
	/// Results are computed per component.
	/// </summary>
	public class ShiftLeftLogical : BaseInstruction
	{
		public override int WordCount => 5;
		public override Operation OpCode => Operation.ShiftLeftLogical;
		
		/// <summary>
		/// Result Type must be a scalar or vector of integer type.
		/// 
		/// The number of components and bit width of Result Type must match those Base type.
		/// All types must be integer types.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// The type of each Base and Shift must be a scalar or vector of integer type.
		/// Base and Shift must have the same number of components.
		/// The number of components and bit width of the type of Base must be the same as in Result Type.
		/// The number of components and bit width of Result Type must match those Base type.
		/// All types must be integer types.
		/// </summary>
		public int BaseId { get; set; }
		
		/// <summary>
		/// The type of each Base and Shift must be a scalar or vector of integer type.
		/// Base and Shift must have the same number of components.
		/// 
		/// Shift is treated as unsigned.
		/// The result is undefined if Shift is greater than the bit width of the components of Base.
		/// All types must be integer types.
		/// </summary>
		public int ShiftId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(BaseId);
			ba.PushUInt32(ShiftId);
			return ba.ToArray();
		}
	}
}
