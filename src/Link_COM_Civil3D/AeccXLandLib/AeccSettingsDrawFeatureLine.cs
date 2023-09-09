namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsDrawFeatureLine 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsDrawFeatureLine _i;
		internal AeccSettingsDrawFeatureLine(object AeccSettingsDrawFeatureLine_object) 
		{
			this._i = AeccSettingsDrawFeatureLine_object as Autodesk.AECC.Interop.Land.IAeccSettingsDrawFeatureLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic FeatureLineCreation => this._i.FeatureLineCreation;
	}
}
