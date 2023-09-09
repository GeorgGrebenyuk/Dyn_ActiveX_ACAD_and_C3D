namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSurfaceBuildOptions 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsSurfaceBuildOptions _i;
		internal AeccSettingsSurfaceBuildOptions(object AeccSettingsSurfaceBuildOptions_object) 
		{
			this._i = AeccSettingsSurfaceBuildOptions_object as Autodesk.AECC.Interop.Land.IAeccSettingsSurfaceBuildOptions;
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
