namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsDrawFeatureLine 
	{
		public AeccXLandLib.IAeccSettingsDrawFeatureLine _i;
		internal AeccSettingsDrawFeatureLine(object AeccSettingsDrawFeatureLine_object) 
		{
			this._i = AeccSettingsDrawFeatureLine_object as AeccXLandLib.IAeccSettingsDrawFeatureLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic FeatureLineCreation => this._i.FeatureLineCreation;
	}
}
