namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBandSectionDataStyle 
	{
		public AeccXLandLib.IAeccBandSectionDataStyle _i;
		internal AeccBandSectionDataStyle(object AeccBandSectionDataStyle_object) 
		{
			this._i = AeccBandSectionDataStyle_object as AeccXLandLib.IAeccBandSectionDataStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MajorIncrementLabelStyle => this._i.MajorIncrementLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic MinorIncrementLabelStyle => this._i.MinorIncrementLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic CenterLineLabelStyle => this._i.CenterLineLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic GradeBreakLabelStyle => this._i.GradeBreakLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic SampleLineVerticesLabelStyle => this._i.SampleLineVerticesLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic MajorOffsetTickDisplayStyle2d => this._i.MajorOffsetTickDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MinorOffsetTickDisplayStyle2d => this._i.MinorOffsetTickDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic GradeBreakTickDisplayStyle2d => this._i.GradeBreakTickDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic CenterLineTickDisplayStyle2d => this._i.CenterLineTickDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MajorOffsetLabelDisplayStyle2d => this._i.MajorOffsetLabelDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MinorOffsetLabelDisplayStyle2d => this._i.MinorOffsetLabelDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic GradeBreakLabelDisplayStyle2d => this._i.GradeBreakLabelDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic CenterLineLabelDisplayStyle2d => this._i.CenterLineLabelDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic SampleLineVertexLabelDisplayStyle2d => this._i.SampleLineVertexLabelDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic SampleLineVertexTickDisplayStyle2d => this._i.SampleLineVertexTickDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MajorOffsetTickDisplayStylePlan => this._i.MajorOffsetTickDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic MinorOffsetTickDisplayStylePlan => this._i.MinorOffsetTickDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic GradeBreakTickDisplayStylePlan => this._i.GradeBreakTickDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic CenterLineTickDisplayStylePlan => this._i.CenterLineTickDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic MajorOffsetLabelDisplayStylePlan => this._i.MajorOffsetLabelDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic MinorOffsetLabelDisplayStylePlan => this._i.MinorOffsetLabelDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic GradeBreakLabelDisplayStylePlan => this._i.GradeBreakLabelDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic CenterLineLabelDisplayStylePlan => this._i.CenterLineLabelDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic SampleLineVertexLabelDisplayStylePlan => this._i.SampleLineVertexLabelDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic SampleLineVertexTickDisplayStylePlan => this._i.SampleLineVertexTickDisplayStylePlan;
	}
}
