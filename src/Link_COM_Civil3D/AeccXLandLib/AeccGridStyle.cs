namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGridStyle 
	{
		public AeccXLandLib.IAeccGridStyle _i;
		internal AeccGridStyle(object AeccGridStyle_object) 
		{
			this._i = AeccGridStyle_object as AeccXLandLib.IAeccGridStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic VerticalPosition => this._i.VerticalPosition;

		///<summary>
		///
		///</summary>
		public dynamic HorizontalPosition => this._i.HorizontalPosition;

		///<summary>
		///
		///</summary>
		public void Set_ClipVertical(bool pVal) 
		{
			this._i.ClipVertical = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ClipVertical => this._i.ClipVertical;

		///<summary>
		///
		///</summary>
		public void Set_ClipHorizontal(bool pVal) 
		{
			this._i.ClipHorizontal = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ClipHorizontal => this._i.ClipHorizontal;

		///<summary>
		///
		///</summary>
		public void Set_GridsAboveMaxElevation(dynamic pVal) 
		{
			this._i.GridsAboveMaxElevation = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic GridsAboveMaxElevation => this._i.GridsAboveMaxElevation;

		///<summary>
		///
		///</summary>
		public void Set_GridsBelowDatum(dynamic pVal) 
		{
			this._i.GridsBelowDatum = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic GridsBelowDatum => this._i.GridsBelowDatum;

		///<summary>
		///
		///</summary>
		public dynamic MajorHorizontalDisplayStyle2d => this._i.MajorHorizontalDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MinorHorizontalDisplayStyle2d => this._i.MinorHorizontalDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MajorVerticalDisplayStyle2d => this._i.MajorVerticalDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MinorVerticalDisplayStyle2d => this._i.MinorVerticalDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MajorHorizontalDisplayStylePlan => this._i.MajorHorizontalDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic MinorHorizontalDisplayStylePlan => this._i.MinorHorizontalDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic MajorVerticalDisplayStylePlan => this._i.MajorVerticalDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic MinorVerticalDisplayStylePlan => this._i.MinorVerticalDisplayStylePlan;
	}
}
