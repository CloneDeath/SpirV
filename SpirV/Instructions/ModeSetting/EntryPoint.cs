using SpirV.Native;

namespace SpirV.Instructions.ModeSetting
{
	/// <summary>
	/// Declare an entry point and its execution model.
	/// </summary>
	public class EntryPoint : BaseInstruction
	{
		public EntryPoint() : this(ExecutionModel.Vertex, 0, "") { }

		public EntryPoint(ExecutionModel executionModel, int entryPoint, string name, params int[] interfaces) {
			ExecutionModel = executionModel;
			EntryPointId = entryPoint;
			Name = name;
			Interface = interfaces;
		}

		public override int WordCount => 3 + ByteArray.GetWordCount(Name) + Interface.Length;
		public override Operation OpCode => Operation.EntryPoint;

		/// <summary>
		/// Execution Model is the execution model for the entry point and its static call tree.
		/// </summary>
		public ExecutionModel ExecutionModel { get; set; }

		/// <summary>
		/// Entry Point must be the Result id of an OpFunction instruction.
		/// </summary>
		public int EntryPointId { get; set; }

		/// <summary>
		/// Name is a name string for the entry point. A module cannot have two OpEntryPoint
		/// instructions with the same Execution Model and the same Name string.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Interface is a list of id of global OpVariable instructions with either Input or Output
		/// for its Storage Class operand. These declare the input/output interface of the entry point.
		/// They could be a subset of the input/output declarations of the module, and a superset of 
		/// those referenced by the entry point’s static call tree. It is invalid for the entry point’s 
		/// static call tree to reference such an id if it was not listed with this instruction.
		/// 
		/// Interface id are forward references. They allow declaration of all variables forming an 
		/// interface for an entry point, whether or not all the variables are actually used by the entry point.
		/// </summary>
		public int[] Interface { get; set; }

		protected override byte[] GetParameterBytes() {
			var byteArray = new ByteArray();
			byteArray.PushUInt32((uint)ExecutionModel);
			byteArray.PushUInt32((uint)EntryPointId);
			byteArray.PushString(Name);
			foreach (var i in Interface) {
				byteArray.PushUInt32((uint)i);
			}
			return byteArray.ToArray();
		}
	}
}
