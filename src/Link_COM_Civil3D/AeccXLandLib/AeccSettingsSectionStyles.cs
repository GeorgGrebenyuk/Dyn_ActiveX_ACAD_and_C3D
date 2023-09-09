namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSectionStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsSectionStyles _i;
		internal AeccSettingsSectionStyles(object AeccSettingsSectionStyles_object) 
		{
			this._i = AeccSettingsSectionStyles_object as Autodesk.AECC.Interop.Land.IAeccSettingsSectionStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public dynamic MajorOffsetLabelStyle => this._i.MajorOffsetLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic MinorOffsetLabelStyle => this._i.MinorOffsetLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic GradeBreakLabelStyle => this._i.GradeBreakLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic SegmentLabelStyle => this._i.SegmentLabelStyle;
	}
}
