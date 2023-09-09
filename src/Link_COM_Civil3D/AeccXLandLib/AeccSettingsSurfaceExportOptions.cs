namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSurfaceExportOptions 
	{
		public AeccXLandLib.IAeccSettingsSurfaceExportOptions _i;
		internal AeccSettingsSurfaceExportOptions(object AeccSettingsSurfaceExportOptions_object) 
		{
			this._i = AeccSettingsSurfaceExportOptions_object as AeccXLandLib.IAeccSettingsSurfaceExportOptions;
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
