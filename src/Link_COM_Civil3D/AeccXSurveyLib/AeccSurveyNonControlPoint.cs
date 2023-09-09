namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyNonControlPoint 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyNonControlPoint _i;
		internal AeccSurveyNonControlPoint(object AeccSurveyNonControlPoint_object) 
		{
			this._i = AeccSurveyNonControlPoint_object as Autodesk.AECC.Interop.Survey.IAeccSurveyNonControlPoint;
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
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void Set_Description(string pbstrDescription) 
		{
			this._i.Description = pbstrDescription;
		}

		///<summary>
		///
		///</summary>
		public dynamic Network => this._i.Network;

		///<summary>
		///
		///</summary>
		public dynamic Project => this._i.Project;

		///<summary>
		///
		///</summary>
		public dynamic PointNumber => this._i.PointNumber;

		///<summary>
		///
		///</summary>
		public double Easting => this._i.Easting;

		///<summary>
		///
		///</summary>
		public void Set_Easting(double pdEasting) 
		{
			this._i.Easting = pdEasting;
		}

		///<summary>
		///
		///</summary>
		public double Northing => this._i.Northing;

		///<summary>
		///
		///</summary>
		public void Set_Northing(double pdNorthing) 
		{
			this._i.Northing = pdNorthing;
		}

		///<summary>
		///
		///</summary>
		public double Elevation => this._i.Elevation;

		///<summary>
		///
		///</summary>
		public void Set_Elevation(double pdElevation) 
		{
			this._i.Elevation = pdElevation;
		}

		///<summary>
		///
		///</summary>
		public double Longitude => this._i.Longitude;

		///<summary>
		///
		///</summary>
		public void Set_Longitude(double pdLongitude) 
		{
			this._i.Longitude = pdLongitude;
		}

		///<summary>
		///
		///</summary>
		public double Latitude => this._i.Latitude;

		///<summary>
		///
		///</summary>
		public void Set_Latitude(double pdLatitude) 
		{
			this._i.Latitude = pdLatitude;
		}
	}
}
