namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSampleLine 
	{
		public AeccXLandLib.IAeccSampleLine _i;
		internal AeccSampleLine(object AeccSampleLine_object) 
		{
			this._i = AeccSampleLine_object as AeccXLandLib.IAeccSampleLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Sections => this._i.Sections;

		///<summary>
		///
		///</summary>
		public dynamic SectionViews => this._i.SectionViews;

		///<summary>
		///
		///</summary>
		public dynamic Vertices => this._i.Vertices;

		///<summary>
		///
		///</summary>
		public dynamic LabelStyle => this._i.LabelStyle;

		///<summary>
		///
		///</summary>
		public void Set_LabelStyle(object ppVal) 
		{
			this._i.LabelStyle = ppVal;
		}

		///<summary>
		///
		///</summary>
		public string StyleName => this._i.StyleName;

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public void Set_Style(object ppVal) 
		{
			this._i.Style = ppVal;
		}

		///<summary>
		///
		///</summary>
		public double Station => this._i.Station;

		///<summary>
		///
		///</summary>
		public void Set_Station(double pVal) 
		{
			this._i.Station = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool LockToStation => this._i.LockToStation;

		///<summary>
		///
		///</summary>
		public void Set_LockToStation(bool pVal) 
		{
			this._i.LockToStation = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Parent => this._i.Parent;
	}
}
