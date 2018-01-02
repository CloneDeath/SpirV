using SpirV.Native;

namespace SpirV.Instructions.Bit
{
	/// <summary>
	/// Extract a bit field from an object, without sign extension.
	/// 
	/// The semantics are the same as with OpBitFieldSExtract with the exception that there is no sign extension.
	/// The remaining bits of the result will all be 0.
	/// </summary>
	public class BitFieldUExtract : BaseInstruction
	{
		public override int WordCount => 6;
		public override Operation OpCode => Operation.BitFieldUExtract;
		
		public int ResultTypeId { get; set; }
		public int ResultId { get; set; }
		public int BaseId { get; set; }
		public int OffsetId { get; set; }
		public int CountId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(BaseId);
			ba.PushUInt32(OffsetId);
			ba.PushUInt32(CountId);
			return ba.ToArray();
		}
	}
}
