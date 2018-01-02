using SpirV.Native;

namespace SpirV.Instructions.Memory
{
	/// <summary>
	/// Length of a run-time array.
	/// </summary>
	public class ArrayLength : BaseInstruction {
		public override int WordCount => 5;
		public override Operation OpCode => Operation.ArrayLength;
		
		/// <summary>
		/// Result Type must be an OpTypeInt with 32-bit Width and 0 Signedness.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Structure must be a pointer to an OpTypeStruct whose last member is a run-time array.
		/// </summary>
		public int StructureId { get; set; }
		
		/// <summary>
		/// Array member is the index of the last member of the structure that Structure points to.
		/// That member’s type must be from OpTypeRuntimeArray.
		/// </summary>
		public int ArrayMember { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint) ResultTypeId);
			byteArray.PushUInt32((uint) ResultId);
			byteArray.PushUInt32((uint) StructureId);
			byteArray.PushUInt32((uint) ArrayMember);
			return byteArray.ToArray();
		}
	}
}
