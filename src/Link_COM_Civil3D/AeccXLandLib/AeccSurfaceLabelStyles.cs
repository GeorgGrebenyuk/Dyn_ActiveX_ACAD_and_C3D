namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceLabelStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceLabelStyles _i;
		internal AeccSurfaceLabelStyles(object AeccSurfaceLabelStyles_object) 
		{
			this._i = AeccSurfaceLabelStyles_object as Autodesk.AECC.Interop.Land.IAeccSurfaceLabelStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ContourLabelStyles => this._i.ContourLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic SlopeLabelStyles => this._i.SlopeLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic SpotElevationLabelStyles => this._i.SpotElevationLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic WatershedLabelStyles => this._i.WatershedLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic MinorContourLabelStyles => this._i.MinorContourLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic UserDefinedContourLabelStyles => this._i.UserDefinedContourLabelStyles;
	}
}
