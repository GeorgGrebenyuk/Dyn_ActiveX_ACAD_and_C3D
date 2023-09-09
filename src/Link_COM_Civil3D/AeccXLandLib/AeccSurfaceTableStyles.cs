namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceTableStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceTableStyles _i;
		internal AeccSurfaceTableStyles(object AeccSurfaceTableStyles_object) 
		{
			this._i = AeccSurfaceTableStyles_object as Autodesk.AECC.Interop.Land.IAeccSurfaceTableStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DirectionTableStyles => this._i.DirectionTableStyles;

		///<summary>
		///
		///</summary>
		public dynamic ElevationTableStyles => this._i.ElevationTableStyles;

		///<summary>
		///
		///</summary>
		public dynamic SlopeTableStyles => this._i.SlopeTableStyles;

		///<summary>
		///
		///</summary>
		public dynamic SlopeArrowTableStyles => this._i.SlopeArrowTableStyles;

		///<summary>
		///
		///</summary>
		public dynamic ContourTableStyles => this._i.ContourTableStyles;

		///<summary>
		///
		///</summary>
		public dynamic WatershedTableStyles => this._i.WatershedTableStyles;
	}
}
