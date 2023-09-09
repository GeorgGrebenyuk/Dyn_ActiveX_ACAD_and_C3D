namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionLabelSet 
	{
		public AeccXLandLib.IAeccSectionLabelSet _i;
		internal AeccSectionLabelSet(object AeccSectionLabelSet_object) 
		{
			this._i = AeccSectionLabelSet_object as AeccXLandLib.IAeccSectionLabelSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MajorStationLabelSet => this._i.MajorStationLabelSet;

		///<summary>
		///
		///</summary>
		public dynamic MinorStationLabelSet => this._i.MinorStationLabelSet;

		///<summary>
		///
		///</summary>
		public dynamic SegmentLabelSet => this._i.SegmentLabelSet;

		///<summary>
		///
		///</summary>
		public dynamic GradeBreaksLabelSet => this._i.GradeBreaksLabelSet;
	}
}
