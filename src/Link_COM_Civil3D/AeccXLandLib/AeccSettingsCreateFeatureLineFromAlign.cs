﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateFeatureLineFromAlign 
	{
		public AeccXLandLib.IAeccSettingsCreateFeatureLineFromAlign _i;
		internal AeccSettingsCreateFeatureLineFromAlign(object AeccSettingsCreateFeatureLineFromAlign_object) 
		{
			this._i = AeccSettingsCreateFeatureLineFromAlign_object as AeccXLandLib.IAeccSettingsCreateFeatureLineFromAlign;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic FeatureLineCreation => this._i.FeatureLineCreation;
	}
}
