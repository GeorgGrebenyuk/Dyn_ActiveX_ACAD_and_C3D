namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelDraggedLeaderStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelDraggedLeaderStyle _i;
		internal AeccLabelDraggedLeaderStyle(object AeccLabelDraggedLeaderStyle_object) 
		{
			this._i = AeccLabelDraggedLeaderStyle_object as Autodesk.AECC.Interop.Land.IAeccLabelDraggedLeaderStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ArrowheadSize => this._i.ArrowheadSize;

		///<summary>
		///
		///</summary>
		public dynamic ArrowheadStyle => this._i.ArrowheadStyle;

		///<summary>
		///
		///</summary>
		public dynamic Color => this._i.Color;

		///<summary>
		///
		///</summary>
		public dynamic Linetype => this._i.Linetype;

		///<summary>
		///
		///</summary>
		public dynamic Lineweight => this._i.Lineweight;

		///<summary>
		///
		///</summary>
		public dynamic Spline => this._i.Spline;

		///<summary>
		///
		///</summary>
		public dynamic Visibility => this._i.Visibility;

		///<summary>
		///
		///</summary>
		public dynamic TrueColor => this._i.TrueColor;
	}
}
