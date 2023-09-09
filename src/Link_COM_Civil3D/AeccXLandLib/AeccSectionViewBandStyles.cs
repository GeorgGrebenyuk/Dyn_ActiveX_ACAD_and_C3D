namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionViewBandStyles 
	{
		public AeccXLandLib.IAeccSectionViewBandStyles _i;
		internal AeccSectionViewBandStyles(object AeccSectionViewBandStyles_object) 
		{
			this._i = AeccSectionViewBandStyles_object as AeccXLandLib.IAeccSectionViewBandStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SectionDataBandStyles => this._i.SectionDataBandStyles;
	}
}
