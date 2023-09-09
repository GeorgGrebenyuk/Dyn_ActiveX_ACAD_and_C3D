namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsImportGEData 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsImportGEData _i;
		internal AeccSettingsImportGEData(object AeccSettingsImportGEData_object) 
		{
			this._i = AeccSettingsImportGEData_object as Autodesk.AECC.Interop.Land.IAeccSettingsImportGEData;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SurfGoogleEarthSettings => this._i.SurfGoogleEarthSettings;
	}
}
