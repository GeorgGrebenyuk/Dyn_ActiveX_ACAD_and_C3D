namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPoint 
	{
		public AeccXLandLib.IAeccPoint _i;
		internal AeccPoint(object AeccPoint_object) 
		{
			this._i = AeccPoint_object as AeccXLandLib.IAeccPoint;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Number => this._i.Number;

		///<summary>
		///
		///</summary>
		public void Set_Number(dynamic pVal) 
		{
			this._i.Number = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Easting => this._i.Easting;

		///<summary>
		///
		///</summary>
		public void Set_Easting(double pVal) 
		{
			this._i.Easting = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Northing => this._i.Northing;

		///<summary>
		///
		///</summary>
		public void Set_Northing(double pVal) 
		{
			this._i.Northing = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Elevation => this._i.Elevation;

		///<summary>
		///
		///</summary>
		public void Set_Elevation(double pVal) 
		{
			this._i.Elevation = pVal;
		}

		///<summary>
		///
		///</summary>
		public object Location => this._i.Location;

		///<summary>
		///
		///</summary>
		public void Set_Location(object pVal) 
		{
			this._i.Location = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Latitude => this._i.Latitude;

		///<summary>
		///
		///</summary>
		public void Set_Latitude(double pVal) 
		{
			this._i.Latitude = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Longitude => this._i.Longitude;

		///<summary>
		///
		///</summary>
		public void Set_Longitude(double pVal) 
		{
			this._i.Longitude = pVal;
		}

		///<summary>
		///
		///</summary>
		public double GridNorthing => this._i.GridNorthing;

		///<summary>
		///
		///</summary>
		public void Set_GridNorthing(double pVal) 
		{
			this._i.GridNorthing = pVal;
		}

		///<summary>
		///
		///</summary>
		public double GridEasting => this._i.GridEasting;

		///<summary>
		///
		///</summary>
		public void Set_GridEasting(double pVal) 
		{
			this._i.GridEasting = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Convergence => this._i.Convergence;

		///<summary>
		///
		///</summary>
		public double Scale => this._i.Scale;

		///<summary>
		///
		///</summary>
		public string RawDescription => this._i.RawDescription;

		///<summary>
		///
		///</summary>
		public void Set_RawDescription(string pVal) 
		{
			this._i.RawDescription = pVal;
		}

		///<summary>
		///
		///</summary>
		public string FullDescription => this._i.FullDescription;

		///<summary>
		///
		///</summary>
		public dynamic LabelStyle => this._i.LabelStyle;

		///<summary>
		///
		///</summary>
		public void Set_LabelStyle(object pVal) 
		{
			this._i.LabelStyle = pVal;
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
		public void Set_Style(object pVal) 
		{
			this._i.Style = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Rotation => this._i.Rotation;

		///<summary>
		///
		///</summary>
		public void Set_Rotation(double pVal) 
		{
			this._i.Rotation = pVal;
		}

		///<summary>
		///
		///</summary>
		public double XYScale => this._i.XYScale;

		///<summary>
		///
		///</summary>
		public void Set_XYScale(double pVal) 
		{
			this._i.XYScale = pVal;
		}

		///<summary>
		///
		///</summary>
		public double ZScale => this._i.ZScale;

		///<summary>
		///
		///</summary>
		public void Set_ZScale(double pVal) 
		{
			this._i.ZScale = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool SurveyPoint => this._i.SurveyPoint;

		///<summary>
		///
		///</summary>
		public string DescriptionFormat => this._i.DescriptionFormat;

		///<summary>
		///
		///</summary>
		public void Set_DescriptionFormat(string pVal) 
		{
			this._i.DescriptionFormat = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ProjectVersion => this._i.ProjectVersion;

		///<summary>
		///
		///</summary>
		public object GetUserDefinedPropertyValue(object userDefinedProperty) 
		{
			return this._i.GetUserDefinedPropertyValue(userDefinedProperty);
		}

		///<summary>
		///
		///</summary>
		public void SetUserDefinedPropertyValue(object userDefinedProperty,object newValue) 
		{
			this._i.SetUserDefinedPropertyValue(userDefinedProperty,newValue);
		}

		///<summary>
		///
		///</summary>
		public double LabelRotation => this._i.LabelRotation;

		///<summary>
		///
		///</summary>
		public void Set_LabelRotation(double pVal) 
		{
			this._i.LabelRotation = pVal;
		}
	}
}
