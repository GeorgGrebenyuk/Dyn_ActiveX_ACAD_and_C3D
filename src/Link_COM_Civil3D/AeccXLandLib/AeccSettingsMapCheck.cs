﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsMapCheck 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsMapCheck _i;
		internal AeccSettingsMapCheck(object AeccSettingsMapCheck_object) 
		{
			this._i = AeccSettingsMapCheck_object as Autodesk.AECC.Interop.Land.IAeccSettingsMapCheck;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic OptionSettings => this._i.OptionSettings;
	}
}
