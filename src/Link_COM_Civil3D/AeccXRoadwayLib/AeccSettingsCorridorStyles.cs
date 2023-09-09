namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCorridorStyles 
	{
		public AeccXRoadwayLib.IAeccSettingsCorridorStyles _i;
		internal AeccSettingsCorridorStyles(object AeccSettingsCorridorStyles_object) 
		{
			this._i = AeccSettingsCorridorStyles_object as AeccXRoadwayLib.IAeccSettingsCorridorStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AlignmentStyle => this._i.AlignmentStyle;

		///<summary>
		///
		///</summary>
		public dynamic SlopePatternStyle => this._i.SlopePatternStyle;

		///<summary>
		///
		///</summary>
		public dynamic CodeSetStyle => this._i.CodeSetStyle;

		///<summary>
		///
		///</summary>
		public dynamic CorridorSurfaceStyle => this._i.CorridorSurfaceStyle;

		///<summary>
		///
		///</summary>
		public dynamic AlignmentLabelSet => this._i.AlignmentLabelSet;

		///<summary>
		///
		///</summary>
		public dynamic ProfileStyle => this._i.ProfileStyle;

		///<summary>
		///
		///</summary>
		public dynamic FeatureLineStyle => this._i.FeatureLineStyle;

		///<summary>
		///
		///</summary>
		public dynamic ProfileLabelSet => this._i.ProfileLabelSet;
	}
}
