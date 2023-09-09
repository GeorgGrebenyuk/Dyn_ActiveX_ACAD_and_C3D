namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceContourStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceContourStyle _i;
		internal AeccSurfaceContourStyle(object AeccSurfaceContourStyle_object) 
		{
			this._i = AeccSurfaceContourStyle_object as Autodesk.AECC.Interop.Land.IAeccSurfaceContourStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string LegendStyle => this._i.LegendStyle;

		///<summary>
		///
		///</summary>
		public void Set_LegendStyle(string pVal) 
		{
			this._i.LegendStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public double BaseElevationInterval => this._i.BaseElevationInterval;

		///<summary>
		///
		///</summary>
		public void Set_BaseElevationInterval(double pVal) 
		{
			this._i.BaseElevationInterval = pVal;
		}

		///<summary>
		///
		///</summary>
		public double MajorContourInterval => this._i.MajorContourInterval;

		///<summary>
		///
		///</summary>
		public void Set_MajorContourInterval(double pVal) 
		{
			this._i.MajorContourInterval = pVal;
		}

		///<summary>
		///
		///</summary>
		public double MinorContourInterval => this._i.MinorContourInterval;

		///<summary>
		///
		///</summary>
		public void Set_MinorContourInterval(double pVal) 
		{
			this._i.MinorContourInterval = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic GroupRangeValuesBy => this._i.GroupRangeValuesBy;

		///<summary>
		///
		///</summary>
		public void Set_GroupRangeValuesBy(Autodesk.AECC.Interop.Land.AeccGroupValuesByType pVal) 
		{
			this._i.GroupRangeValuesBy = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NumberOfRanges => this._i.NumberOfRanges;

		///<summary>
		///
		///</summary>
		public void Set_NumberOfRanges(dynamic pVal) 
		{
			this._i.NumberOfRanges = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic RangePrecision => this._i.RangePrecision;

		///<summary>
		///
		///</summary>
		public void Set_RangePrecision(Autodesk.AECC.Interop.Land.AeccPrecisionRangeType pVal) 
		{
			this._i.RangePrecision = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseColorScheme => this._i.UseColorScheme;

		///<summary>
		///
		///</summary>
		public void Set_UseColorScheme(bool pVal) 
		{
			this._i.UseColorScheme = pVal;
		}

		///<summary>
		///
		///</summary>
		public string MajorContourColorScheme => this._i.MajorContourColorScheme;

		///<summary>
		///
		///</summary>
		public void Set_MajorContourColorScheme(string pVal) 
		{
			this._i.MajorContourColorScheme = pVal;
		}

		///<summary>
		///
		///</summary>
		public string MinorContourColorScheme => this._i.MinorContourColorScheme;

		///<summary>
		///
		///</summary>
		public void Set_MinorContourColorScheme(string pVal) 
		{
			this._i.MinorContourColorScheme = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool DisplayDepressions => this._i.DisplayDepressions;

		///<summary>
		///
		///</summary>
		public void Set_DisplayDepressions(bool pVal) 
		{
			this._i.DisplayDepressions = pVal;
		}

		///<summary>
		///
		///</summary>
		public double DepressionTickMarkInterval => this._i.DepressionTickMarkInterval;

		///<summary>
		///
		///</summary>
		public void Set_DepressionTickMarkInterval(double pVal) 
		{
			this._i.DepressionTickMarkInterval = pVal;
		}

		///<summary>
		///
		///</summary>
		public double DepressionTickMarkLength => this._i.DepressionTickMarkLength;

		///<summary>
		///
		///</summary>
		public void Set_DepressionTickMarkLength(double pVal) 
		{
			this._i.DepressionTickMarkLength = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool SmoothContours => this._i.SmoothContours;

		///<summary>
		///
		///</summary>
		public void Set_SmoothContours(bool pVal) 
		{
			this._i.SmoothContours = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic SmoothingType => this._i.SmoothingType;

		///<summary>
		///
		///</summary>
		public void Set_SmoothingType(Autodesk.AECC.Interop.Land.AeccContourSmoothingType pVal) 
		{
			this._i.SmoothingType = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic SmoothingFactor => this._i.SmoothingFactor;

		///<summary>
		///
		///</summary>
		public void Set_SmoothingFactor(dynamic pVal) 
		{
			this._i.SmoothingFactor = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic MinorContourDisplayStyle2d => this._i.MinorContourDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MajorContourDisplayStyle2d => this._i.MajorContourDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic MinorContourDisplayStyle3d => this._i.MinorContourDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic MajorContourDisplayStyle3d => this._i.MajorContourDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic UserContourDisplayStyle2d => this._i.UserContourDisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic UserContourDisplayStyle3d => this._i.UserContourDisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic MinorContourDisplayStylePlan => this._i.MinorContourDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic MajorContourDisplayStylePlan => this._i.MajorContourDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic MinorContourDisplayStyleModel => this._i.MinorContourDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic MajorContourDisplayStyleModel => this._i.MajorContourDisplayStyleModel;

		///<summary>
		///
		///</summary>
		public dynamic UserContourDisplayStylePlan => this._i.UserContourDisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic UserContourDisplayStyleModel => this._i.UserContourDisplayStyleModel;
	}
}
