namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBandHorizontalGeometryStyle 
	{
		public AeccXLandLib.IAeccBandHorizontalGeometryStyle _i;
		internal AeccBandHorizontalGeometryStyle(object AeccBandHorizontalGeometryStyle_object) 
		{
			this._i = AeccBandHorizontalGeometryStyle_object as AeccXLandLib.IAeccBandHorizontalGeometryStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TangentLabelStyle => this._i.TangentLabelStyle;

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
		public dynamic TickDisplayStyle2d => this._i.TickDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic TangentLabelDisplayStyle2d => this._i.TangentLabelDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic CurveLabelDisplayStyle2d => this._i.CurveLabelDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic SpiralLabelDisplayStyle2d => this._i.SpiralLabelDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic TangentGeometryDisplayStyle2d => this._i.TangentGeometryDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic CurveGeometryDisplayStyle2d => this._i.CurveGeometryDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic SpiralGeometryDisplayStyle2d => this._i.SpiralGeometryDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic TickDisplayStylePlan => this._i.TickDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic TangentLabelDisplayStylePlan => this._i.TangentLabelDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic CurveLabelDisplayStylePlan => this._i.CurveLabelDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic SpiralLabelDisplayStylePlan => this._i.SpiralLabelDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic TangentGeometryDisplayStylePlan => this._i.TangentGeometryDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic CurveGeometryDisplayStylePlan => this._i.CurveGeometryDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic SpiralGeometryDisplayStylePlan => this._i.SpiralGeometryDisplayStylePlan;
	}
}
