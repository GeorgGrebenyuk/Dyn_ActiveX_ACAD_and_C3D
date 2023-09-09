﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumStationDelimiterCharacter 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumStationDelimiterCharacter _i;
		internal AeccPropertyEnumStationDelimiterCharacter(object AeccPropertyEnumStationDelimiterCharacter_object) 
		{
			this._i = AeccPropertyEnumStationDelimiterCharacter_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumStationDelimiterCharacter;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccStationDelimiterCharacterType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
