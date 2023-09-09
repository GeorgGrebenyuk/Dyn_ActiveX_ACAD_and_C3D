namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionViewLabelStyles 
	{
		public AeccXLandLib.IAeccSectionViewLabelStyles _i;
		internal AeccSectionViewLabelStyles(object AeccSectionViewLabelStyles_object) 
		{
			this._i = AeccSectionViewLabelStyles_object as AeccXLandLib.IAeccSectionViewLabelStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic OffsetElevationLabelStyles => this._i.OffsetElevationLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic GradeLabelStyles => this._i.GradeLabelStyles;
	}
}
