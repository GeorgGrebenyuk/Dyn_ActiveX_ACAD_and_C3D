namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAlignmentStyles 
	{
		public AeccXLandLib.IAeccSettingsAlignmentStyles _i;
		internal AeccSettingsAlignmentStyles(object AeccSettingsAlignmentStyles_object) 
		{
			this._i = AeccSettingsAlignmentStyles_object as AeccXLandLib.IAeccSettingsAlignmentStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public dynamic PointStyle => this._i.PointStyle;

		///<summary>
		///
		///</summary>
		public dynamic LabelStyleSet => this._i.LabelStyleSet;

		///<summary>
		///
		///</summary>
		public dynamic LineLabelStyle => this._i.LineLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic CurveLabelStyle => this._i.CurveLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic SpiralLabelStyle => this._i.SpiralLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic StationOffsetLabelStyle => this._i.StationOffsetLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic MajorStationLabelStyle => this._i.MajorStationLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic MinorStationLabelStyle => this._i.MinorStationLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic StationEquationLabelStyle => this._i.StationEquationLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic GeometryPointLabelStyle => this._i.GeometryPointLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic LabelAnchorMarkerStyle => this._i.LabelAnchorMarkerStyle;
	}
}
