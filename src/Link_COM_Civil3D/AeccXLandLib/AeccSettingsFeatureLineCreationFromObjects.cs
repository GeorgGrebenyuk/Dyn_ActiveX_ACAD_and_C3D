namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsFeatureLineCreationFromObjects 
	{
		public AeccXLandLib.IAeccSettingsFeatureLineCreationFromObjects _i;
		internal AeccSettingsFeatureLineCreationFromObjects(object AeccSettingsFeatureLineCreationFromObjects_object) 
		{
			this._i = AeccSettingsFeatureLineCreationFromObjects_object as AeccXLandLib.IAeccSettingsFeatureLineCreationFromObjects;
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
		public dynamic EraseExistingEntities => this._i.EraseExistingEntities;

		///<summary>
		///
		///</summary>
		public dynamic WeedPoints => this._i.WeedPoints;

		///<summary>
		///
		///</summary>
		public dynamic AssignElevations => this._i.AssignElevations;

		///<summary>
		///
		///</summary>
		public dynamic ElevationSource => this._i.ElevationSource;

		///<summary>
		///
		///</summary>
		public dynamic IncludeIntermediateElevBreaks => this._i.IncludeIntermediateElevBreaks;
	}
}
