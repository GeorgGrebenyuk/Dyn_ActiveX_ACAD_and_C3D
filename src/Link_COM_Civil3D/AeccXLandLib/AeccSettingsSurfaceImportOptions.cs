namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSurfaceImportOptions 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsSurfaceImportOptions _i;
		internal AeccSettingsSurfaceImportOptions(object AeccSettingsSurfaceImportOptions_object) 
		{
			this._i = AeccSettingsSurfaceImportOptions_object as Autodesk.AECC.Interop.Land.IAeccSettingsSurfaceImportOptions;
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
