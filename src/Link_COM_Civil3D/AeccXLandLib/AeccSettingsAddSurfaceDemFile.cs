namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddSurfaceDemFile 
	{
		public AeccXLandLib.IAeccSettingsAddSurfaceDemFile _i;
		internal AeccSettingsAddSurfaceDemFile(object AeccSettingsAddSurfaceDemFile_object) 
		{
			this._i = AeccSettingsAddSurfaceDemFile_object as AeccXLandLib.IAeccSettingsAddSurfaceDemFile;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SurfaceImportOptionsSettings => this._i.SurfaceImportOptionsSettings;
	}
}
