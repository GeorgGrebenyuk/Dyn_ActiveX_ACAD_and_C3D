﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateSheets 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateSheets _i;
		internal AeccSettingsCreateSheets(object AeccSettingsCreateSheets_object) 
		{
			this._i = AeccSettingsCreateSheets_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateSheets;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreationSettings => this._i.CreationSettings;
	}
}
