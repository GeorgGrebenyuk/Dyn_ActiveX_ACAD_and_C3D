namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBandVerticalGeometryStyle 
	{
		public AeccXLandLib.IAeccBandVerticalGeometryStyle _i;
		internal AeccBandVerticalGeometryStyle(object AeccBandVerticalGeometryStyle_object) 
		{
			this._i = AeccBandVerticalGeometryStyle_object as AeccXLandLib.IAeccBandVerticalGeometryStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic UphillTangentLabelStyle => this._i.UphillTangentLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic DownhillTangentLabelStyle => this._i.DownhillTangentLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic CrestCurveLabelStyle => this._i.CrestCurveLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic SagCurveLabelStyle => this._i.SagCurveLabelStyle;

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
		public dynamic TangentGeometryDisplayStyle2d => this._i.TangentGeometryDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic CurveGeometryDisplayStyle2d => this._i.CurveGeometryDisplayStyle2d;

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
		public dynamic TangentGeometryDisplayStylePlan => this._i.TangentGeometryDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic CurveGeometryDisplayStylePlan => this._i.CurveGeometryDisplayStylePlan;
	}
}
