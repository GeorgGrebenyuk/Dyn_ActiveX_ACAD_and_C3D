namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsFeatureLineCreationFromCorridor 
	{
		public AeccXRoadwayLib.IAeccSettingsFeatureLineCreationFromCorridor _i;
		internal AeccSettingsFeatureLineCreationFromCorridor(object AeccSettingsFeatureLineCreationFromCorridor_object) 
		{
			this._i = AeccSettingsFeatureLineCreationFromCorridor_object as AeccXRoadwayLib.IAeccSettingsFeatureLineCreationFromCorridor;
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
		public dynamic SmoothFeatureLine => this._i.SmoothFeatureLine;

		///<summary>
		///
		///</summary>
		public dynamic HorizontalDeviation => this._i.HorizontalDeviation;

		///<summary>
		///
		///</summary>
		public dynamic InclusionDistance => this._i.InclusionDistance;

		///<summary>
		///
		///</summary>
		public dynamic WeedingDistance => this._i.WeedingDistance;
	}
}
