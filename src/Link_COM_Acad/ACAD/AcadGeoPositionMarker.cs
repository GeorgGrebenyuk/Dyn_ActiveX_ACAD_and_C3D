namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadGeoPositionMarker 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadGeoPositionMarker _i;
		internal AcadGeoPositionMarker(object AcadGeoPositionMarker_object) 
		{
			this._i = AcadGeoPositionMarker_object as Autodesk.AutoCAD.Interop.Common.IAcadGeoPositionMarker;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object Position => this._i.Position;

		///<summary>
		///
		///</summary>
		public void Set_Position(object Position) 
		{
			this._i.Position = Position;
		}

		///<summary>
		///
		///</summary>
		public string TextString => this._i.TextString;

		///<summary>
		///
		///</summary>
		public void Set_TextString(string bstrText) 
		{
			this._i.TextString = bstrText;
		}

		///<summary>
		///
		///</summary>
		public string TextStyleName => this._i.TextStyleName;

		///<summary>
		///
		///</summary>
		public void Set_TextStyleName(string bstrName) 
		{
			this._i.TextStyleName = bstrName;
		}

		///<summary>
		///
		///</summary>
		public dynamic TextJustify => this._i.TextJustify;

		///<summary>
		///
		///</summary>
		public void Set_TextJustify(Autodesk.AutoCAD.Interop.Common.AcAttachmentPoint attPoint) 
		{
			this._i.TextJustify = attPoint;
		}

		///<summary>
		///
		///</summary>
		public dynamic DrawingDirection => this._i.DrawingDirection;

		///<summary>
		///
		///</summary>
		public void Set_DrawingDirection(Autodesk.AutoCAD.Interop.Common.AcDrawingDirection drawDir) 
		{
			this._i.DrawingDirection = drawDir;
		}

		///<summary>
		///
		///</summary>
		public double TextWidth => this._i.TextWidth;

		///<summary>
		///
		///</summary>
		public void Set_TextWidth(double Width) 
		{
			this._i.TextWidth = Width;
		}

		///<summary>
		///
		///</summary>
		public double Height => this._i.Height;

		///<summary>
		///
		///</summary>
		public void Set_Height(double Height) 
		{
			this._i.Height = Height;
		}

		///<summary>
		///
		///</summary>
		public dynamic Rotation => this._i.Rotation;

		///<summary>
		///
		///</summary>
		public void Set_Rotation(dynamic rotAngle) 
		{
			this._i.Rotation = rotAngle;
		}

		///<summary>
		///
		///</summary>
		public double LineSpacingFactor => this._i.LineSpacingFactor;

		///<summary>
		///
		///</summary>
		public void Set_LineSpacingFactor(double factor) 
		{
			this._i.LineSpacingFactor = factor;
		}

		///<summary>
		///
		///</summary>
		public double LineSpacingDistance => this._i.LineSpacingDistance;

		///<summary>
		///
		///</summary>
		public void Set_LineSpacingDistance(double Value) 
		{
			this._i.LineSpacingDistance = Value;
		}

		///<summary>
		///
		///</summary>
		public dynamic LineSpacingStyle => this._i.LineSpacingStyle;

		///<summary>
		///
		///</summary>
		public void Set_LineSpacingStyle(Autodesk.AutoCAD.Interop.Common.AcLineSpacingStyle style) 
		{
			this._i.LineSpacingStyle = style;
		}

		///<summary>
		///
		///</summary>
		public bool BackgroundFill => this._i.BackgroundFill;

		///<summary>
		///
		///</summary>
		public void Set_BackgroundFill(bool bUseBackgroundFill) 
		{
			this._i.BackgroundFill = bUseBackgroundFill;
		}

		///<summary>
		///
		///</summary>
		public double LandingGap => this._i.LandingGap;

		///<summary>
		///
		///</summary>
		public void Set_LandingGap(double gap) 
		{
			this._i.LandingGap = gap;
		}

		///<summary>
		///
		///</summary>
		public double Radius => this._i.Radius;

		///<summary>
		///
		///</summary>
		public void Set_Radius(double gap) 
		{
			this._i.Radius = gap;
		}

		///<summary>
		///
		///</summary>
		public bool TextFrameDisplay => this._i.TextFrameDisplay;

		///<summary>
		///
		///</summary>
		public void Set_TextFrameDisplay(bool pVal) 
		{
			this._i.TextFrameDisplay = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Latitude => this._i.Latitude;

		///<summary>
		///
		///</summary>
		public void Set_Latitude(string Latitude) 
		{
			this._i.Latitude = Latitude;
		}

		///<summary>
		///
		///</summary>
		public string Longitude => this._i.Longitude;

		///<summary>
		///
		///</summary>
		public void Set_Longitude(string Longitude) 
		{
			this._i.Longitude = Longitude;
		}

		///<summary>
		///
		///</summary>
		public double Altitude => this._i.Altitude;

		///<summary>
		///
		///</summary>
		public void Set_Altitude(double Altitude) 
		{
			this._i.Altitude = Altitude;
		}

		///<summary>
		///
		///</summary>
		public string Notes => this._i.Notes;

		///<summary>
		///
		///</summary>
		public void Set_Notes(string Notes) 
		{
			this._i.Notes = Notes;
		}
	}
}
