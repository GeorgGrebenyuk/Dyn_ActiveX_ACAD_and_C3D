namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyFigurePrefix 
	{
		public AeccXSurveyLib.IAeccSurveyFigurePrefix _i;
		internal AeccSurveyFigurePrefix(object AeccSurveyFigurePrefix_object) 
		{
			this._i = AeccSurveyFigurePrefix_object as AeccXSurveyLib.IAeccSurveyFigurePrefix;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string pbstrName) 
		{
			this._i.Name = pbstrName;
		}

		///<summary>
		///
		///</summary>
		public bool IsBreakline => this._i.IsBreakline;

		///<summary>
		///
		///</summary>
		public void Set_IsBreakline(bool pbIsBreakline) 
		{
			this._i.IsBreakline = pbIsBreakline;
		}

		///<summary>
		///
		///</summary>
		public bool IsLotLine => this._i.IsLotLine;

		///<summary>
		///
		///</summary>
		public void Set_IsLotLine(bool pbIsLotLine) 
		{
			this._i.IsLotLine = pbIsLotLine;
		}

		///<summary>
		///
		///</summary>
		public string Layer => this._i.Layer;

		///<summary>
		///
		///</summary>
		public void Set_Layer(string pbstrLayer) 
		{
			this._i.Layer = pbstrLayer;
		}

		///<summary>
		///
		///</summary>
		public string Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public void Set_Style(string pbstrStyle) 
		{
			this._i.Style = pbstrStyle;
		}

		///<summary>
		///
		///</summary>
		public string Site => this._i.Site;

		///<summary>
		///
		///</summary>
		public void Set_Site(string pbstrSite) 
		{
			this._i.Site = pbstrSite;
		}

		///<summary>
		///
		///</summary>
		public void CopyFrom(dynamic piFigurePrefix) 
		{
			this._i.CopyFrom(piFigurePrefix);
		}
	}
}
