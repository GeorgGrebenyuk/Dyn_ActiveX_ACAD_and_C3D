﻿namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsSubassembly 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsCommandsSubassembly _i;
		internal AeccSettingsCommandsSubassembly(object AeccSettingsCommandsSubassembly_object) 
		{
			this._i = AeccSettingsCommandsSubassembly_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsCommandsSubassembly;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreateSubAssemblyTool => this._i.CreateSubAssemblyTool;

		///<summary>
		///
		///</summary>
		public dynamic CreateSubFromPline => this._i.CreateSubFromPline;
	}
}
