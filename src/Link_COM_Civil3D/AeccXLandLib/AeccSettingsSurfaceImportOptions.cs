namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSurfaceImportOptions 
	{
		public AeccXLandLib.IAeccSettingsSurfaceImportOptions _i;
		internal AeccSettingsSurfaceImportOptions(object AeccSettingsSurfaceImportOptions_object) 
		{
			this._i = AeccSettingsSurfaceImportOptions_object as AeccXLandLib.IAeccSettingsSurfaceImportOptions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

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
