namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyPoint 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyPoint _i;
		internal AeccSurveyPoint(object AeccSurveyPoint_object) 
		{
			this._i = AeccSurveyPoint_object as Autodesk.AECC.Interop.Survey.IAeccSurveyPoint;
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
		public dynamic Project => this._i.Project;

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public dynamic Number => this._i.Number;

		///<summary>
		///
		///</summary>
		public double Easting => this._i.Easting;

		///<summary>
		///
		///</summary>
		public double Northing => this._i.Northing;

		///<summary>
		///
		///</summary>
		public double Elevation => this._i.Elevation;

		///<summary>
		///
		///</summary>
		public double Longitude => this._i.Longitude;

		///<summary>
		///
		///</summary>
		public double Latitude => this._i.Latitude;

		///<summary>
		///
		///</summary>
		public double Bulge => this._i.Bulge;

		///<summary>
		///
		///</summary>
		public dynamic Unit => this._i.Unit;

		///<summary>
		///
		///</summary>
		public bool IsControlPoint => this._i.IsControlPoint;

		///<summary>
		///
		///</summary>
		public bool IsSetupPoint => this._i.IsSetupPoint;

		///<summary>
		///
		///</summary>
		public bool IsNorthEastSideShotPoint => this._i.IsNorthEastSideShotPoint;

		///<summary>
		///
		///</summary>
		public void ConvertToFeet() 
		{
			this._i.ConvertToFeet();
		}

		///<summary>
		///
		///</summary>
		public void ConvertToUsFeet() 
		{
			this._i.ConvertToUsFeet();
		}

		///<summary>
		///
		///</summary>
		public void ConvertToMeter() 
		{
			this._i.ConvertToMeter();
		}

		///<summary>
		///
		///</summary>
		public void ConvertToUnit(Autodesk.AECC.Interop.Survey.AeccSurveyPointDistanceUnit nUnit) 
		{
			this._i.ConvertToUnit(nUnit);
		}

		///<summary>
		///
		///</summary>
		public object CalculateDrawingCoordinate(dynamic piDatabase) 
		{
			return this._i.CalculateDrawingCoordinate(piDatabase);
		}

		///<summary>
		///
		///</summary>
		public void ConvertToDrawingUnit(dynamic piDatabase) 
		{
			this._i.ConvertToDrawingUnit(piDatabase);
		}

		///<summary>
		///
		///</summary>
		public void ConvertFromDrawingUnit(dynamic piDatabase) 
		{
			this._i.ConvertFromDrawingUnit(piDatabase);
		}

		///<summary>
		///
		///</summary>
		public dynamic NetworkId => this._i.NetworkId;

		///<summary>
		///
		///</summary>
		public void Set_NetworkId(dynamic pnNetworkId) 
		{
			this._i.NetworkId = pnNetworkId;
		}

		///<summary>
		///
		///</summary>
		public dynamic Monument => this._i.Monument;

		///<summary>
		///
		///</summary>
		public void Set_Monument(dynamic pnMonument) 
		{
			this._i.Monument = pnMonument;
		}

		///<summary>
		///
		///</summary>
		public string LandXML => this._i.LandXML;

		///<summary>
		///
		///</summary>
		public void Set_LandXML(string pnLandXML) 
		{
			this._i.LandXML = pnLandXML;
		}

		///<summary>
		///
		///</summary>
		public object FindSetupsThatObserveMe => this._i.FindSetupsThatObserveMe;

		///<summary>
		///
		///</summary>
		public dynamic LandXMLXPropertiesRoot => this._i.LandXMLXPropertiesRoot;

		///<summary>
		///
		///</summary>
		public dynamic UserDefinedXProperties => this._i.UserDefinedXProperties;
	}
}
