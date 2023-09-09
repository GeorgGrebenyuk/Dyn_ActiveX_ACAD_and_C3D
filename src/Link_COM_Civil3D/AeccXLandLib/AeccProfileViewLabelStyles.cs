namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileViewLabelStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileViewLabelStyles _i;
		internal AeccProfileViewLabelStyles(object AeccProfileViewLabelStyles_object) 
		{
			this._i = AeccProfileViewLabelStyles_object as Autodesk.AECC.Interop.Land.IAeccProfileViewLabelStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic StationElevationLabelStyles => this._i.StationElevationLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic DepthLabelStyles => this._i.DepthLabelStyles;
	}
}
