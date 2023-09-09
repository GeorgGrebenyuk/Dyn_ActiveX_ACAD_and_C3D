namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSurfaceBuildOptions 
	{
		public AeccXLandLib.IAeccSettingsSurfaceBuildOptions _i;
		internal AeccSettingsSurfaceBuildOptions(object AeccSettingsSurfaceBuildOptions_object) 
		{
			this._i = AeccSettingsSurfaceBuildOptions_object as AeccXLandLib.IAeccSettingsSurfaceBuildOptions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic UseMaxTriangleLen => this._i.UseMaxTriangleLen;

		///<summary>
		///
		///</summary>
		public dynamic TrianglLenMax => this._i.TrianglLenMax;

		///<summary>
		///
		///</summary>
		public dynamic ConvertBreaklinesStd => this._i.ConvertBreaklinesStd;

		///<summary>
		///
		///</summary>
		public dynamic AllowCrossBreaklines => this._i.AllowCrossBreaklines;

		///<summary>
		///
		///</summary>
		public dynamic UseElevation => this._i.UseElevation;
	}
}
