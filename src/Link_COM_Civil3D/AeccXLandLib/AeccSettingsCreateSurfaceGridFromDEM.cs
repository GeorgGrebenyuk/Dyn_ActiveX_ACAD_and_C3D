namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateSurfaceGridFromDEM 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateSurfaceGridFromDEM _i;
		internal AeccSettingsCreateSurfaceGridFromDEM(object AeccSettingsCreateSurfaceGridFromDEM_object) 
		{
			this._i = AeccSettingsCreateSurfaceGridFromDEM_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateSurfaceGridFromDEM;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SurfaceGridBuildOptionsSettings => this._i.SurfaceGridBuildOptionsSettings;

		///<summary>
		///
		///</summary>
		public dynamic SurfaceImportOptionsSettings => this._i.SurfaceImportOptionsSettings;
	}
}
