namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateGradingFeatureLine 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateGradingFeatureLine _i;
		internal AeccSettingsCreateGradingFeatureLine(object AeccSettingsCreateGradingFeatureLine_object) 
		{
			this._i = AeccSettingsCreateGradingFeatureLine_object as Autodesk.AECC.Interop.Roadway.IAeccSettingsCreateGradingFeatureLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic FeatureLineCreation => this._i.FeatureLineCreation;
	}
}
