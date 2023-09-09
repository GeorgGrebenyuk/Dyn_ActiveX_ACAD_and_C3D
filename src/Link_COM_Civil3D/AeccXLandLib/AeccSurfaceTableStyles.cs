namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceTableStyles 
	{
		public AeccXLandLib.IAeccSurfaceTableStyles _i;
		internal AeccSurfaceTableStyles(object AeccSurfaceTableStyles_object) 
		{
			this._i = AeccSurfaceTableStyles_object as AeccXLandLib.IAeccSurfaceTableStyles;
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
