using SpirV.Native;

namespace SpirV.Instructions.Conversion
{
	/// <summary>
	/// Bit pattern-preserving type conversion.
	/// </summary>
	public class Bitcast : BaseInstruction
	{
		public override int WordCount => 4;
		public override Operation OpCode => Operation.Bitcast;
		
		/// <summary>
		/// Result Type must be an OpTypePointer, or a scalar or vector of numerical-type.
		/// 
		/// If Result Type is a pointer, Operand must be a pointer or integer scalar.
		/// If Operand is a pointer, Result Type must be a pointer or integer scalar.
		/// 
		/// If Result Type has the same number of components as Operand, they must also have the same component width,
		/// and results are computed per component.
		/// 
		/// If Result Type has a different number of components than Operand, the total number of bits in Result
		/// Type must equal the total number of bits in Operand.
		/// Let L be the type, either Result Type or Operand’s type, that has the larger number of components.
		/// Let S be the other type, with the smaller number of components.
		/// The number of components in L must be an integer multiple of the number of components in S.
		/// The first component (that is, the only or lowest-numbered component) of S maps to the first components
		/// of L, and so on, up to the last component of S mapping to the last components of L.
		/// Within this mapping, any single component of S (mapping to multiple components of L) maps its
		/// lower-ordered bits to the lower-numbered components of L.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Operand must have a type of OpTypePointer, or a scalar or vector of numerical-type.
		/// It must be a different type than Result Type.
		/// </summary>
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
