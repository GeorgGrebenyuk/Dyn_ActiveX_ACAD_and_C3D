namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionLabelStyleSet 
	{
		public AeccXLandLib.IAeccSectionLabelStyleSet _i;
		internal AeccSectionLabelStyleSet(object AeccSectionLabelStyleSet_object) 
		{
			this._i = AeccSectionLabelStyleSet_object as AeccXLandLib.IAeccSectionLabelStyleSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MajorStationLabelStyleSet => this._i.MajorStationLabelStyleSet;

		///<summary>
		///
		///</summary>
		public dynamic MinorStationLabelStyleSet => this._i.MinorStationLabelStyleSet;

		///<summary>
		///
		///</summary>
		public dynamic SegmentLabelStyleSet => this._i.SegmentLabelStyleSet;

		///<summary>
		///
		///</summary>
		public dynamic GradeBreaksLabelStyleSet => this._i.GradeBreaksLabelStyleSet;
	}
}
