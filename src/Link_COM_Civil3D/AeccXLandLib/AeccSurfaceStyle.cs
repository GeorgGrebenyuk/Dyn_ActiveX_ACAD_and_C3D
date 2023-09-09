namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceStyle _i;
		internal AeccSurfaceStyle(object AeccSurfaceStyle_object) 
		{
			this._i = AeccSurfaceStyle_object as Autodesk.AECC.Interop.Land.IAeccSurfaceStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic BoundaryStyle => this._i.BoundaryStyle;

		///<summary>
		///
		///</summary>
		public dynamic ContourStyle => this._i.ContourStyle;

		///<summary>
		///
		///</summary>
		public dynamic DirectionStyle => this._i.DirectionStyle;

		///<summary>
		///
		///</summary>
		public dynamic ElevationStyle => this._i.ElevationStyle;

		///<summary>
		///
		///</summary>
		public dynamic GridStyle => this._i.GridStyle;

		///<summary>
		///
		///</summary>
		public dynamic PointStyle => this._i.PointStyle;

		///<summary>
		///
		///</summary>
		public dynamic SlopeArrowStyle => this._i.SlopeArrowStyle;

		///<summary>
		///
		///</summary>
		public dynamic SlopeStyle => this._i.SlopeStyle;

		///<summary>
		///
		///</summary>
		public dynamic WatershedStyle => this._i.WatershedStyle;

		///<summary>
		///
		///</summary>
		public dynamic TriangleStyle => this._i.TriangleStyle;
	}
}
