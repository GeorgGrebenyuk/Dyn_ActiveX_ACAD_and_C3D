namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsSampleLine 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCommandsSampleLine _i;
		internal AeccSettingsCommandsSampleLine(object AeccSettingsCommandsSampleLine_object) 
		{
			this._i = AeccSettingsCommandsSampleLine_object as Autodesk.AECC.Interop.Land.IAeccSettingsCommandsSampleLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreateSampleLinesSettings => this._i.CreateSampleLinesSettings;
	}
}
