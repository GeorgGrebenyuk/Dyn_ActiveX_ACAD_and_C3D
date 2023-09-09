namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsSampleLine 
	{
		public AeccXLandLib.IAeccSettingsCommandsSampleLine _i;
		internal AeccSettingsCommandsSampleLine(object AeccSettingsCommandsSampleLine_object) 
		{
			this._i = AeccSettingsCommandsSampleLine_object as AeccXLandLib.IAeccSettingsCommandsSampleLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreateSampleLinesSettings => this._i.CreateSampleLinesSettings;
	}
}
