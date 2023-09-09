namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSurfaceExportOptions 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsSurfaceExportOptions _i;
		internal AeccSettingsSurfaceExportOptions(object AeccSettingsSurfaceExportOptions_object) 
		{
			this._i = AeccSettingsSurfaceExportOptions_object as Autodesk.AECC.Interop.Land.IAeccSettingsSurfaceExportOptions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic GridSpacing => this._i.GridSpacing;

		///<summary>
		///
		///</summary>
		public dynamic UseNullElevation => this._i.UseNullElevation;

		///<summary>
		///
		///</summary>
		public dynamic NullElevation => this._i.NullElevation;
	}
}
