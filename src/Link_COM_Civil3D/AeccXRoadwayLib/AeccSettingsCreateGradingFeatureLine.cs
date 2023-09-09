namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateGradingFeatureLine 
	{
		public AeccXRoadwayLib.IAeccSettingsCreateGradingFeatureLine _i;
		internal AeccSettingsCreateGradingFeatureLine(object AeccSettingsCreateGradingFeatureLine_object) 
		{
			this._i = AeccSettingsCreateGradingFeatureLine_object as AeccXRoadwayLib.IAeccSettingsCreateGradingFeatureLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic FeatureLineCreation => this._i.FeatureLineCreation;
	}
}
