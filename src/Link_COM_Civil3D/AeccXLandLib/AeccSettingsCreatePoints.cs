﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreatePoints 
	{
		public AeccXLandLib.IAeccSettingsCreatePoints _i;
		internal AeccSettingsCreatePoints(object AeccSettingsCreatePoints_object) 
		{
			this._i = AeccSettingsCreatePoints_object as AeccXLandLib.IAeccSettingsCreatePoints;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic PointCreationSettings => this._i.PointCreationSettings;

		///<summary>
		///
		///</summary>
		public dynamic PointIdentitySettings => this._i.PointIdentitySettings;

		///<summary>
		///
		///</summary>
		public dynamic DefaultLayer => this._i.DefaultLayer;
	}
}
