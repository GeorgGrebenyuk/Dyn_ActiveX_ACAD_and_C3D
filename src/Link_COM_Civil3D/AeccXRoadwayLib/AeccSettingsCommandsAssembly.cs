namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsAssembly 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsCommandsAssembly _i;
		internal AeccSettingsCommandsAssembly(object AeccSettingsCommandsAssembly_object) 
		{
			this._i = AeccSettingsCommandsAssembly_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsCommandsAssembly;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreateAssembly => this._i.CreateAssembly;

		///<summary>
		///
		///</summary>
		public dynamic CreateAssemblyTool => this._i.CreateAssemblyTool;
	}
}
