﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBandSetItem 
	{
		public Autodesk.AECC.Interop.Land.IAeccBandSetItem _i;
		internal AeccBandSetItem(object AeccBandSetItem_object) 
		{
			this._i = AeccBandSetItem_object as Autodesk.AECC.Interop.Land.IAeccBandSetItem;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic BandStyle => this._i.BandStyle;

		///<summary>
		///
		///</summary>
		public void Set_Gap(double pVal) 
		{
			this._i.Gap = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Gap => this._i.Gap;

		///<summary>
		///
		///</summary>
		public void Set_Location(Autodesk.AECC.Interop.Land.AeccBandSetItemLocationType pVal) 
		{
			this._i.Location = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Location => this._i.Location;
	}
}
