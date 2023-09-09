namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsImportGEData 
	{
		public AeccXLandLib.IAeccSettingsImportGEData _i;
		internal AeccSettingsImportGEData(object AeccSettingsImportGEData_object) 
		{
			this._i = AeccSettingsImportGEData_object as AeccXLandLib.IAeccSettingsImportGEData;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SurfGoogleEarthSettings => this._i.SurfGoogleEarthSettings;
	}
}
