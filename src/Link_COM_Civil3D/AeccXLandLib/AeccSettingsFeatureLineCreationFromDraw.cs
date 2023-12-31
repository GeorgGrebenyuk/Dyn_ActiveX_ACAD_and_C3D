﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsFeatureLineCreationFromDraw 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsFeatureLineCreationFromDraw _i;
		internal AeccSettingsFeatureLineCreationFromDraw(object AeccSettingsFeatureLineCreationFromDraw_object) 
		{
			this._i = AeccSettingsFeatureLineCreationFromDraw_object as Autodesk.AECC.Interop.Land.IAeccSettingsFeatureLineCreationFromDraw;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic FeatureLineName => this._i.FeatureLineName;

		///<summary>
		///
		///</summary>
		public dynamic UseFeatureLineStyle => this._i.UseFeatureLineStyle;

		///<summary>
		///
		///</summary>
		public dynamic LayerSetting => this._i.LayerSetting;
	}
}
