namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileLabelStyles 
	{
		public AeccXLandLib.IAeccProfileLabelStyles _i;
		internal AeccProfileLabelStyles(object AeccProfileLabelStyles_object) 
		{
			this._i = AeccProfileLabelStyles_object as AeccXLandLib.IAeccProfileLabelStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MajorStationLabelStyles => this._i.MajorStationLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic MinorStationLabelStyles => this._i.MinorStationLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic HorizontalGeometryPointLabelStyles => this._i.HorizontalGeometryPointLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic LineLabelStyles => this._i.LineLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic CurveLabelStyles => this._i.CurveLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic GradeBreakLabelStyles => this._i.GradeBreakLabelStyles;
	}
}
