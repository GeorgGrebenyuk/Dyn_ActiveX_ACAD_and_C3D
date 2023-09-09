namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGoogleEarthOptions 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsGoogleEarthOptions _i;
		internal AeccSettingsGoogleEarthOptions(object AeccSettingsGoogleEarthOptions_object) 
		{
			this._i = AeccSettingsGoogleEarthOptions_object as Autodesk.AECC.Interop.Land.IAeccSettingsGoogleEarthOptions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic GoogleEarthRows => this._i.GoogleEarthRows;

		///<summary>
		///
		///</summary>
		public dynamic GoogleEarthColumns => this._i.GoogleEarthColumns;
	}
}
