namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGradingStyles 
	{
		public AeccXLandLib.IAeccSettingsGradingStyles _i;
		internal AeccSettingsGradingStyles(object AeccSettingsGradingStyles_object) 
		{
			this._i = AeccSettingsGradingStyles_object as AeccXLandLib.IAeccSettingsGradingStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public dynamic FeatureLineStyle => this._i.FeatureLineStyle;

		///<summary>
		///
		///</summary>
		public dynamic CutSlopeGradingStyle => this._i.CutSlopeGradingStyle;

		///<summary>
		///
		///</summary>
		public dynamic FillSlopeGradingStyle => this._i.FillSlopeGradingStyle;
	}
}
