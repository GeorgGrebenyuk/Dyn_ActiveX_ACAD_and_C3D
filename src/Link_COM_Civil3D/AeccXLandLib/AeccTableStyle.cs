namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccTableStyle 
	{
		public AeccXLandLib.IAeccTableStyle _i;
		internal AeccTableStyle(object AeccTableStyle_object) 
		{
			this._i = AeccTableStyle_object as AeccXLandLib.IAeccTableStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public string Title => this._i.Title;

		///<summary>
		///
		///</summary>
		public void Set_Title(string pVal) 
		{
			this._i.Title = pVal;
		}

		///<summary>
		///
		///</summary>
		public string TitleUnformatted => this._i.TitleUnformatted;

		///<summary>
		///
		///</summary>
		public void Set_TitleUnformatted(string pVal) 
		{
			this._i.TitleUnformatted = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic TitleJustification => this._i.TitleJustification;

		///<summary>
		///
		///</summary>
		public void Set_TitleJustification(AeccXLandLib.AeccTableTitleJustificationType pVal) 
		{
			this._i.TitleJustification = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool RepeatTitleInSplitTables => this._i.RepeatTitleInSplitTables;

		///<summary>
		///
		///</summary>
		public void Set_RepeatTitleInSplitTables(bool pVal) 
		{
			this._i.RepeatTitleInSplitTables = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool RepeatHeaderInSplitTables => this._i.RepeatHeaderInSplitTables;

		///<summary>
		///
		///</summary>
		public void Set_RepeatHeaderInSplitTables(bool pVal) 
		{
			this._i.RepeatHeaderInSplitTables = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool SortData => this._i.SortData;

		///<summary>
		///
		///</summary>
		public void Set_SortData(bool pVal) 
		{
			this._i.SortData = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic SortingOrder => this._i.SortingOrder;

		///<summary>
		///
		///</summary>
		public void Set_SortingOrder(AeccXLandLib.AeccTableSortingOrderType pVal) 
		{
			this._i.SortingOrder = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic SortingColumn => this._i.SortingColumn;

		///<summary>
		///
		///</summary>
		public void Set_SortingColumn(object pVal) 
		{
			this._i.SortingColumn = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool EnableWordWrapping => this._i.EnableWordWrapping;

		///<summary>
		///
		///</summary>
		public void Set_EnableWordWrapping(bool pVal) 
		{
			this._i.EnableWordWrapping = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool MaintainViewOrientation => this._i.MaintainViewOrientation;

		///<summary>
		///
		///</summary>
		public void Set_MaintainViewOrientation(bool pVal) 
		{
			this._i.MaintainViewOrientation = pVal;
		}

		///<summary>
		///
		///</summary>
		public string TitleTextStyle => this._i.TitleTextStyle;

		///<summary>
		///
		///</summary>
		public void Set_TitleTextStyle(string pVal) 
		{
			this._i.TitleTextStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public string HeaderTextStyle => this._i.HeaderTextStyle;

		///<summary>
		///
		///</summary>
		public void Set_HeaderTextStyle(string pVal) 
		{
			this._i.HeaderTextStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public string DataTextStyle => this._i.DataTextStyle;

		///<summary>
		///
		///</summary>
		public void Set_DataTextStyle(string pVal) 
		{
			this._i.DataTextStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public double TitleTextHeight => this._i.TitleTextHeight;

		///<summary>
		///
		///</summary>
		public void Set_TitleTextHeight(double pVal) 
		{
			this._i.TitleTextHeight = pVal;
		}

		///<summary>
		///
		///</summary>
		public double HeaderTextHeight => this._i.HeaderTextHeight;

		///<summary>
		///
		///</summary>
		public void Set_HeaderTextHeight(double pVal) 
		{
			this._i.HeaderTextHeight = pVal;
		}

		///<summary>
		///
		///</summary>
		public double DataTextHeight => this._i.DataTextHeight;

		///<summary>
		///
		///</summary>
		public void Set_DataTextHeight(double pVal) 
		{
			this._i.DataTextHeight = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ColumnStyles => this._i.ColumnStyles;

		///<summary>
		///
		///</summary>
		public dynamic BorderDisplayStyle2d => this._i.BorderDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic BorderDisplayStyle3d => this._i.BorderDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic TitleSeparatorDisplayStyle2d => this._i.TitleSeparatorDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic TitleSeparatorDisplayStyle3d => this._i.TitleSeparatorDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic HeaderSeparatorDisplayStyle2d => this._i.HeaderSeparatorDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic HeaderSeparatorDisplayStyle3d => this._i.HeaderSeparatorDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic DataSeparatorDisplayStyle2d => this._i.DataSeparatorDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic DataSeparatorDisplayStyle3d => this._i.DataSeparatorDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic DataDividerDisplayStyle2d => this._i.DataDividerDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic DataDividerDisplayStyle3d => this._i.DataDividerDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic TitleAreaFillDisplayStyle2d => this._i.TitleAreaFillDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic TitleAreaFillDisplayStyle3d => this._i.TitleAreaFillDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic HeaderAreaFillDisplayStyle2d => this._i.HeaderAreaFillDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic HeaderAreaFillDisplayStyle3d => this._i.HeaderAreaFillDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic DataAreaFillDisplayStyle2d => this._i.DataAreaFillDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic DataAreaFillDisplayStyle3d => this._i.DataAreaFillDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic TitleTextDisplayStyle2d => this._i.TitleTextDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic TitleTextDisplayStyle3d => this._i.TitleTextDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic HeaderTextDisplayStyle2d => this._i.HeaderTextDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic HeaderTextDisplayStyle3d => this._i.HeaderTextDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic DataTextDisplayStyle2d => this._i.DataTextDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic DataTextDisplayStyle3d => this._i.DataTextDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic Children => this._i.Children;

		///<summary>
		///
		///</summary>
		public dynamic Descendants => this._i.Descendants;

		///<summary>
		///
		///</summary>
		public dynamic Parent => this._i.Parent;

		///<summary>
		///method Init
		///</summary>
		public void Init(AeccXLandLib.AeccTableStyleType newVal) 
		{
			this._i.Init(newVal);
		}

		///<summary>
		///
		///</summary>
		public dynamic BorderDisplayStylePlan => this._i.BorderDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic BorderDisplayStyleModel => this._i.BorderDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic TitleSeparatorDisplayStylePlan => this._i.TitleSeparatorDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic TitleSeparatorDisplayStyleModel => this._i.TitleSeparatorDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic HeaderSeparatorDisplayStylePlan => this._i.HeaderSeparatorDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic HeaderSeparatorDisplayStyleModel => this._i.HeaderSeparatorDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic DataSeparatorDisplayStylePlan => this._i.DataSeparatorDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic DataSeparatorDisplayStyleModel => this._i.DataSeparatorDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic DataDividerDisplayStylePlan => this._i.DataDividerDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic DataDividerDisplayStyleModel => this._i.DataDividerDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic TitleAreaFillDisplayStylePlan => this._i.TitleAreaFillDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic TitleAreaFillDisplayStyleModel => this._i.TitleAreaFillDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic HeaderAreaFillDisplayStylePlan => this._i.HeaderAreaFillDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic HeaderAreaFillDisplayStyleModel => this._i.HeaderAreaFillDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic DataAreaFillDisplayStylePlan => this._i.DataAreaFillDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic DataAreaFillDisplayStyleModel => this._i.DataAreaFillDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic TitleTextDisplayStylePlan => this._i.TitleTextDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic TitleTextDisplayStyleModel => this._i.TitleTextDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic HeaderTextDisplayStylePlan => this._i.HeaderTextDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic HeaderTextDisplayStyleModel => this._i.HeaderTextDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic DataTextDisplayStylePlan => this._i.DataTextDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic DataTextDisplayStyleModel => this._i.DataTextDisplayStyleModel;
	}
}
