namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentTableStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentTableStyles _i;
		internal AeccAlignmentTableStyles(object AeccAlignmentTableStyles_object) 
		{
			this._i = AeccAlignmentTableStyles_object as Autodesk.AECC.Interop.Land.IAeccAlignmentTableStyles;
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
		public dynamic SpiralTableStyles => this._i.SpiralTableStyles;

		///<summary>
		///
		///</summary>
		public dynamic SegmentTableStyles => this._i.SegmentTableStyles;
	}
}
