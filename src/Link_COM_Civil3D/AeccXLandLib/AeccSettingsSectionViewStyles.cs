namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSectionViewStyles 
	{
		public AeccXLandLib.IAeccSettingsSectionViewStyles _i;
		internal AeccSettingsSectionViewStyles(object AeccSettingsSectionViewStyles_object) 
		{
			this._i = AeccSettingsSectionViewStyles_object as AeccXLandLib.IAeccSettingsSectionViewStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public dynamic BandStyleSet => this._i.BandStyleSet;

		///<summary>
		///
		///</summary>
		public dynamic PointStyle => this._i.PointStyle;

		///<summary>
		///
		///</summary>
		public dynamic OffsetElevationLabelStyle => this._i.OffsetElevationLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic DepthGradeLabelStyle => this._i.DepthGradeLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic LabelStyleSet => this._i.LabelStyleSet;

		///<summary>
		///
		///</summary>
		public dynamic GroupPlotStyle => this._i.GroupPlotStyle;

		///<summary>
		///
		///</summary>
		public dynamic LabelAnchorMarkerStyle => this._i.LabelAnchorMarkerStyle;
	}
}
