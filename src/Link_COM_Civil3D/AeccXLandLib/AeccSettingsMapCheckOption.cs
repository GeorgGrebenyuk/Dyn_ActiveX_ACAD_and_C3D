namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsMapCheckOption 
	{
		public AeccXLandLib.IAeccSettingsMapCheckOption _i;
		internal AeccSettingsMapCheckOption(object AeccSettingsMapCheckOption_object) 
		{
			this._i = AeccSettingsMapCheckOption_object as AeccXLandLib.IAeccSettingsMapCheckOption;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic UseCommandLine => this._i.UseCommandLine;

		///<summary>
		///
		///</summary>
		public dynamic DefaultSideType => this._i.DefaultSideType;

		///<summary>
		///
		///</summary>
		public dynamic DefaultCurveDirection => this._i.DefaultCurveDirection;

		///<summary>
		///
		///</summary>
		public dynamic DefaultAngleType => this._i.DefaultAngleType;

		///<summary>
		///
		///</summary>
		public dynamic DefaultCurveTraverseMethod => this._i.DefaultCurveTraverseMethod;

		///<summary>
		///
		///</summary>
		public dynamic MapcheckColor => this._i.MapcheckColor;

		///<summary>
		///
		///</summary>
		public dynamic CurrentMapcheckColor => this._i.CurrentMapcheckColor;

		///<summary>
		///
		///</summary>
		public dynamic CurrentPointOfBeginningColor => this._i.CurrentPointOfBeginningColor;

		///<summary>
		///
		///</summary>
		public dynamic CurrentSideColor => this._i.CurrentSideColor;
	}
}
