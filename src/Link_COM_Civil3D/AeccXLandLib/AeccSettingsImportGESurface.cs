namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsImportGESurface 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsImportGESurface _i;
		internal AeccSettingsImportGESurface(object AeccSettingsImportGESurface_object) 
		{
			this._i = AeccSettingsImportGESurface_object as Autodesk.AECC.Interop.Land.IAeccSettingsImportGESurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SurfGoogleEarthSettings => this._i.SurfGoogleEarthSettings;
	}
}
