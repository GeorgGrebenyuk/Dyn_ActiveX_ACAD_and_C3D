﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateParcelFromObjects 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateParcelFromObjects _i;
		internal AeccSettingsCreateParcelFromObjects(object AeccSettingsCreateParcelFromObjects_object) 
		{
			this._i = AeccSettingsCreateParcelFromObjects_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateParcelFromObjects;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AutoAddSegmentLabels => this._i.AutoAddSegmentLabels;

		///<summary>
		///
		///</summary>
		public dynamic EraseAllExistingEntities => this._i.EraseAllExistingEntities;
	}
}
