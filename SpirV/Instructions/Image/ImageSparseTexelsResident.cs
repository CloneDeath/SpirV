using SpirV.Native;

namespace SpirV.Instructions.Image
{
	/// <summary>
	/// Translates a Resident Code into a Boolean.
	/// Result is false if any of the texels were in uncommitted texture memory, and true otherwise.
	/// </summary>
	public class ImageSparseTexelsResident : BaseInstruction {
		public override int WordCount => 4;
		public override Operation OpCode => Operation.ImageSparseTexelsResident;

		/// <summary>
		/// Result Type must be a Boolean type scalar. 
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Resident Code is a value from an OpImageSparse… instruction that returns a resident code.
		/// </summary>
		public int ResidentCodeId { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(ResidentCodeId);
			return ba.ToArray();
		}
	}
}
