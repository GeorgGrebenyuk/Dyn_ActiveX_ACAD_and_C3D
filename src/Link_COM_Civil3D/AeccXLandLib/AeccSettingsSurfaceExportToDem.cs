namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSurfaceExportToDem 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsSurfaceExportToDem _i;
		internal AeccSettingsSurfaceExportToDem(object AeccSettingsSurfaceExportToDem_object) 
		{
			this._i = AeccSettingsSurfaceExportToDem_object as Autodesk.AECC.Interop.Land.IAeccSettingsSurfaceExportToDem;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SurfaceExportSettings => this._i.SurfaceExportSettings;
	}
}
