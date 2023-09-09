namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelTableStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccParcelTableStyles _i;
		internal AeccParcelTableStyles(object AeccParcelTableStyles_object) 
		{
			this._i = AeccParcelTableStyles_object as Autodesk.AECC.Interop.Land.IAeccParcelTableStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic LineTableStyles => this._i.LineTableStyles;

		///<summary>
		///
		///</summary>
		public dynamic CurveTableStyles => this._i.CurveTableStyles;

		///<summary>
		///
		///</summary>
		public dynamic SegmentTableStyles => this._i.SegmentTableStyles;

		///<summary>
		///
		///</summary>
		public dynamic AreaTableStyles => this._i.AreaTableStyles;
	}
}
