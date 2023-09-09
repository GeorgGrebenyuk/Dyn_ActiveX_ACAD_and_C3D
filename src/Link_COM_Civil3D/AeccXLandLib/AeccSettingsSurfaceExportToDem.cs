namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSurfaceExportToDem 
	{
		public AeccXLandLib.IAeccSettingsSurfaceExportToDem _i;
		internal AeccSettingsSurfaceExportToDem(object AeccSettingsSurfaceExportToDem_object) 
		{
			this._i = AeccSettingsSurfaceExportToDem_object as AeccXLandLib.IAeccSettingsSurfaceExportToDem;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SurfaceExportSettings => this._i.SurfaceExportSettings;
	}
}
