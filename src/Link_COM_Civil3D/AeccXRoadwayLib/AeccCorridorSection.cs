﻿namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCorridorSection 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccCorridorSection _i;
		internal AeccCorridorSection(object AeccCorridorSection_object) 
		{
			this._i = AeccCorridorSection_object as Autodesk.AECC.Interop.Roadway.IAeccCorridorSection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Corridor => this._i.Corridor;

		///<summary>
		///
		///</summary>
		public void Set_Corridor(object pVal) 
		{
			this._i.Corridor = pVal;
		}
	}
}
