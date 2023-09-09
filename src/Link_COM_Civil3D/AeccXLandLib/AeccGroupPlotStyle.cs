namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGroupPlotStyle 
	{
		public AeccXLandLib.IAeccGroupPlotStyle _i;
		internal AeccGroupPlotStyle(object AeccGroupPlotStyle_object) 
		{
			this._i = AeccGroupPlotStyle_object as AeccXLandLib.IAeccGroupPlotStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_PlotSectionViewsBy(AeccXLandLib.AeccGroupPlotRuleType pVal) 
		{
			this._i.PlotSectionViewsBy = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic PlotSectionViewsBy => this._i.PlotSectionViewsBy;

		///<summary>
		///
		///</summary>
		public void Set_MaximumInRow(dynamic pVal) 
		{
			this._i.MaximumInRow = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic MaximumInRow => this._i.MaximumInRow;

		///<summary>
		///
		///</summary>
		public void Set_MaximumInColumn(dynamic pVal) 
		{
			this._i.MaximumInColumn = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic MaximumInColumn => this._i.MaximumInColumn;

		///<summary>
		///
		///</summary>
		public void Set_StartCorner(AeccXLandLib.AeccGroupPlotCornerType pVal) 
		{
			this._i.StartCorner = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic StartCorner => this._i.StartCorner;

		///<summary>
		///
		///</summary>
		public void Set_AlignSectionViewsAbout(AeccXLandLib.AeccGroupPlotAlignViewType pVal) 
		{
			this._i.AlignSectionViewsAbout = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic AlignSectionViewsAbout => this._i.AlignSectionViewsAbout;

		///<summary>
		///
		///</summary>
		public void Set_CellSize(AeccXLandLib.AeccGroupPlotCellSizeType pVal) 
		{
			this._i.CellSize = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic CellSize => this._i.CellSize;

		///<summary>
		///
		///</summary>
		public void Set_PlotBy(AeccXLandLib.AeccGroupPlotAreaType pVal) 
		{
			this._i.PlotBy = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic PlotBy => this._i.PlotBy;

		///<summary>
		///
		///</summary>
		public void Set_GapBetweenPages(double pVal) 
		{
			this._i.GapBetweenPages = pVal;
		}

		///<summary>
		///
		///</summary>
		public double GapBetweenPages => this._i.GapBetweenPages;

		///<summary>
		///
		///</summary>
		public void Set_SheetStyle(object pVal) 
		{
			this._i.SheetStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic SheetStyle => this._i.SheetStyle;
	}
}
