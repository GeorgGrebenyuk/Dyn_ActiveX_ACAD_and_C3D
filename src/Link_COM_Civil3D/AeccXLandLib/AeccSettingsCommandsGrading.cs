namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsGrading 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCommandsGrading _i;
		internal AeccSettingsCommandsGrading(object AeccSettingsCommandsGrading_object) 
		{
			this._i = AeccSettingsCommandsGrading_object as Autodesk.AECC.Interop.Land.IAeccSettingsCommandsGrading;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreateFeatureLineFromAlignSettings => this._i.CreateFeatureLineFromAlignSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateFeatureLinesSettings => this._i.CreateFeatureLinesSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateGradingSettings => this._i.CreateGradingSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateGradingGroupSettings => this._i.CreateGradingGroupSettings;

		///<summary>
		///
		///</summary>
		public dynamic DrawFeatureLineSettings => this._i.DrawFeatureLineSettings;

		///<summary>
		///
		///</summary>
		public dynamic FitCurveFeatureSettings => this._i.FitCurveFeatureSettings;

		///<summary>
		///
		///</summary>
		public dynamic GradingElevEditorSettings => this._i.GradingElevEditorSettings;

		///<summary>
		///
		///</summary>
		public dynamic GradingToolsSettings => this._i.GradingToolsSettings;

		///<summary>
		///
		///</summary>
		public dynamic GradingVolumeToolsSettings => this._i.GradingVolumeToolsSettings;

		///<summary>
		///
		///</summary>
		public dynamic JoinFeaturesSettings => this._i.JoinFeaturesSettings;

		///<summary>
		///
		///</summary>
		public dynamic WeedFeaturesSettings => this._i.WeedFeaturesSettings;
	}
}
