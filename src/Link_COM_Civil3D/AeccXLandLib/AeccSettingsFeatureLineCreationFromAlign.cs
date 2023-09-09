namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsFeatureLineCreationFromAlign 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsFeatureLineCreationFromAlign _i;
		internal AeccSettingsFeatureLineCreationFromAlign(object AeccSettingsFeatureLineCreationFromAlign_object) 
		{
			this._i = AeccSettingsFeatureLineCreationFromAlign_object as Autodesk.AECC.Interop.Land.IAeccSettingsFeatureLineCreationFromAlign;
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

		///<summary>
		///
		///</summary>
		public dynamic CreateDynamicLink => this._i.CreateDynamicLink;

		///<summary>
		///
		///</summary>
		public dynamic MidOrdinateDistance => this._i.MidOrdinateDistance;
	}
}
