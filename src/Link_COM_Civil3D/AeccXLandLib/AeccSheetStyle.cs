namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSheetStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSheetStyle _i;
		internal AeccSheetStyle(object AeccSheetStyle_object) 
		{
			this._i = AeccSheetStyle_object as Autodesk.AECC.Interop.Land.IAeccSheetStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_PageLayout(string pVal) 
		{
			this._i.PageLayout = pVal;
		}

		///<summary>
		///
		///</summary>
		public string PageLayout => this._i.PageLayout;

		///<summary>
		///
		///</summary>
		public dynamic MajorHorizontalGridDisplayStyle2d => this._i.MajorHorizontalGridDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MinorHorizontalGridDisplayStyle2d => this._i.MinorHorizontalGridDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MajorVerticalGridDisplayStyle2d => this._i.MajorVerticalGridDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MinorVerticalGridDisplayStyle2d => this._i.MinorVerticalGridDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic SheetBorderDisplayStyle2d => this._i.SheetBorderDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic PrintAreaDisplayStyle2d => this._i.PrintAreaDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MajorHorizontalGridDisplayStylePlan => this._i.MajorHorizontalGridDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic MinorHorizontalGridDisplayStylePlan => this._i.MinorHorizontalGridDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic MajorVerticalGridDisplayStylePlan => this._i.MajorVerticalGridDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic MinorVerticalGridDisplayStylePlan => this._i.MinorVerticalGridDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic SheetBorderDisplayStylePlan => this._i.SheetBorderDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic PrintAreaDisplayStylePlan => this._i.PrintAreaDisplayStylePlan;
	}
}
