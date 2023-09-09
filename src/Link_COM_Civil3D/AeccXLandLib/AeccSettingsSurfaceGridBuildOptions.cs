namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSurfaceGridBuildOptions 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsSurfaceGridBuildOptions _i;
		internal AeccSettingsSurfaceGridBuildOptions(object AeccSettingsSurfaceGridBuildOptions_object) 
		{
			this._i = AeccSettingsSurfaceGridBuildOptions_object as Autodesk.AECC.Interop.Land.IAeccSettingsSurfaceGridBuildOptions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CopyDelDepenObjects => this._i.CopyDelDepenObjects;

		///<summary>
		///
		///</summary>
		public dynamic ExcludeElvtnsLThan => this._i.ExcludeElvtnsLThan;

		///<summary>
		///
		///</summary>
		public dynamic ExcludeElvtnsGThan => this._i.ExcludeElvtnsGThan;

		///<summary>
		///
		///</summary>
		public dynamic ElevationMax => this._i.ElevationMax;

		///<summary>
		///
		///</summary>
		public dynamic ElevationMin => this._i.ElevationMin;
	}
}
