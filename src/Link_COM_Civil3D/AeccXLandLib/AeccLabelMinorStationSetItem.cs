﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelMinorStationSetItem 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelMinorStationSetItem _i;
		internal AeccLabelMinorStationSetItem(object AeccLabelMinorStationSetItem_object) 
		{
			this._i = AeccLabelMinorStationSetItem_object as Autodesk.AECC.Interop.Land.IAeccLabelMinorStationSetItem;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Parent => this._i.Parent;
	}
}
