namespace SpirV.Native {
	/// <summary>
	/// The execution scope or memory scope of an operation.
	/// When used as a memory scope, it specifies the distance of synchronization from the current invocation.
	/// When used as an execution scope, it specifies the set of executing invocations taking part in the operation.
	/// </summary>
	public enum Scope {
		/// <summary>
		/// Scope crosses multiple devices.
		/// </summary>
		CrossDevice = 0,
		
		/// <summary>
		/// Scope is the current device.
		/// </summary>
		Device = 1,
		
		/// <summary>
		/// Scope is the current workgroup.
		/// </summary>
		Workgroup = 2,
		
		/// <summary>
		/// Scope is the current subgroup.
		/// </summary>
		Subgroup = 3,
		
		/// <summary>
		/// Scope is the current Invocation.
		/// </summary>
		Invocation = 4
	}
}