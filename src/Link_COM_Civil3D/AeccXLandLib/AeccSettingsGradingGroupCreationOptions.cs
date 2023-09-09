namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGradingGroupCreationOptions 
	{
		public AeccXLandLib.IAeccSettingsGradingGroupCreationOptions _i;
		internal AeccSettingsGradingGroupCreationOptions(object AeccSettingsGradingGroupCreationOptions_object) 
		{
			this._i = AeccSettingsGradingGroupCreationOptions_object as AeccXLandLib.IAeccSettingsGradingGroupCreationOptions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic GradingSurfaceCreation => this._i.GradingSurfaceCreation;

		///<summary>
		///
		///</summary>
		public dynamic UseGroupName => this._i.UseGroupName;

		///<summary>
		///
		///</summary>
		public dynamic SurfaceStyle => this._i.SurfaceStyle;

		///<summary>
		///
		///</summary>
		public dynamic SurfaceTessellationIncrement => this._i.SurfaceTessellationIncrement;

		///<summary>
		///
		///</summary>
		public dynamic SurfaceConeTessellationAngle => this._i.SurfaceConeTessellationAngle;
	}
}
