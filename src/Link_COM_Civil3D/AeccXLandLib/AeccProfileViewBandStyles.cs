namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileViewBandStyles 
	{
		public AeccXLandLib.IAeccProfileViewBandStyles _i;
		internal AeccProfileViewBandStyles(object AeccProfileViewBandStyles_object) 
		{
			this._i = AeccProfileViewBandStyles_object as AeccXLandLib.IAeccProfileViewBandStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ProfileDataBandStyles => this._i.ProfileDataBandStyles;

		///<summary>
		///
		///</summary>
		public dynamic VerticalGeometryBandStyles => this._i.VerticalGeometryBandStyles;

		///<summary>
		///
		///</summary>
		public dynamic HorizontalGeometryBandStyles => this._i.HorizontalGeometryBandStyles;

		///<summary>
		///
		///</summary>
		public dynamic SuperElevationBandStyles => this._i.SuperElevationBandStyles;

		///<summary>
		///
		///</summary>
		public dynamic SectionDataBandStyles => this._i.SectionDataBandStyles;
	}
}
