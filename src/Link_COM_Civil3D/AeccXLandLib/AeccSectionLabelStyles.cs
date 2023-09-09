namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionLabelStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionLabelStyles _i;
		internal AeccSectionLabelStyles(object AeccSectionLabelStyles_object) 
		{
			this._i = AeccSectionLabelStyles_object as Autodesk.AECC.Interop.Land.IAeccSectionLabelStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MajorOffsetLabelStyles => this._i.MajorOffsetLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic MinorOffsetLabelStyles => this._i.MinorOffsetLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic GradeBreakLabelStyles => this._i.GradeBreakLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic SegmentLabelStyles => this._i.SegmentLabelStyles;
	}
}
