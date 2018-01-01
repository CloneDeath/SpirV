using SpirV.Native;

namespace SpirV.Instructions.TypeDeclaration
{
	/// <summary>
	/// Declare an OpenCL pipe type.
	/// </summary>
	public class TypePipe : BaseInstruction
	{
		public override int WordCount => 3;
		public override Operation OpCode => Operation.TypePipe;
		
		public int ResultId { get; set; }
		
		/// <summary>
		/// Qualifier is the pipe access qualifier.
		/// </summary>
		public AccessQualifier Qualifier { get; set; }
		
		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint) ResultId);
			byteArray.PushUInt32((uint) Qualifier);
			return byteArray.ToArray();
		}
	}
}
