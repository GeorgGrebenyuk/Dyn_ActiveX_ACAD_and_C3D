namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionViewBandStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionViewBandStyles _i;
		internal AeccSectionViewBandStyles(object AeccSectionViewBandStyles_object) 
		{
			this._i = AeccSectionViewBandStyles_object as Autodesk.AECC.Interop.Land.IAeccSectionViewBandStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SectionDataBandStyles => this._i.SectionDataBandStyles;
	}
}
