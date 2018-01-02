using SpirV.Native;

namespace SpirV.Instructions.Conversion
{
	/// <summary>
	/// Attempts to explicitly convert Pointer to Storage storage-class pointer value. 
	/// </summary>
	public class GenericCastToPtrExplicit : BaseInstruction
	{
		public override int WordCount => 5;
		public override Operation OpCode => Operation.GenericCastToPtrExplicit;
		
		/// <summary>
		/// Result Type must be an OpTypePointer.
		/// Its Storage Class must be Storage.
		/// </summary>
		public int ResultTypeId { get; set; }
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Pointer must have a type of OpTypePointer whose Type is the same as the Type of Result Type.
		/// Pointer must point to the Generic Storage Class.
		/// If the cast fails, the instruction result is an OpConstantNull pointer in the Storage Storage Class.
		/// </summary>
		public int PointerId { get; set; }
		
		/// <summary>
		/// Storage must be one of the following literal values from Storage Class:
		/// Workgroup, CrossWorkgroup, or Function.
		/// </summary>
		public StorageClass Storage { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var ba = new ByteArray();
			ba.PushUInt32(ResultTypeId);
			ba.PushUInt32(ResultId);
			ba.PushUInt32(PointerId);
			ba.PushUInt32((uint)Storage);
			return ba.ToArray();
		}
	}
}
