﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGeoEntity 
	{
		public Autodesk.AECC.Interop.Land.IAeccGeoEntity _i;
		internal AeccGeoEntity(object AeccGeoEntity_object) 
		{
			this._i = AeccGeoEntity_object as Autodesk.AECC.Interop.Land.IAeccGeoEntity;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Position => this._i.Position;
	}
}
