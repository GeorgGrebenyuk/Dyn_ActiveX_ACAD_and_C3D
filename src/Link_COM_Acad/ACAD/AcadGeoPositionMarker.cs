using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

    ///<summary>
    /// A geographical location aware marker object with a label. You cannot create a GeoPositionMarker entity via ActiveX, but can copy existed
    ///</summary>
    public class AcadGeoPositionMarker 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadGeoPositionMarker _i;
		internal AcadGeoPositionMarker(object AcadGeoPositionMarker_object) 
		{
			this._i = AcadGeoPositionMarker_object as Autodesk.AutoCAD.Interop.Common.AcadGeoPositionMarker;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadGeoPositionMarker(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadGeoPositionMarker;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }
        /// <summary>
        /// Copy existed AcadGeoPositionMarker
        /// </summary>
        /// <param name="AcadGeoPositionMarker"></param>
        /// <param name="NewName"></param>
        /// <param name="newPosition"></param>
        public AcadGeoPositionMarker(AcadGeoPositionMarker AcadGeoPositionMarker, string NewName, Point newPosition)
        {
            this._i = AcadGeoPositionMarker._i.Copy() as Autodesk.AutoCAD.Interop.Common.AcadGeoPositionMarker;
            this._i.TextString = NewName;
			this.Set_Position(newPosition);
        }

        ///<summary>
        ///
        ///</summary>
        public Point Position => Technical.PointByDoubleArray(this._i.Position);

		///<summary>
		///
		///</summary>
		public void Set_Position(Point Position) 
		{
			this._i.Position = Technical.PointByDynPoint(Position);
		}

		///<summary>
		/// Tag string
		///</summary>
		public string TextString => this._i.TextString;

        ///<summary>
        ///Tag string
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
        ///Specifies the attachment point of the MText
        ///</summary>
        public dynamic TextJustify => this._i.TextJustify;

        ///<summary>
        ///Specifies the attachment point of the MText
        ///</summary>
        public void Set_TextJustify(Autodesk.AutoCAD.Interop.Common.AcAttachmentPoint attPoint) 
		{
			this._i.TextJustify = attPoint;
		}

        ///<summary>
        ///Specifies the direction in which the mtext paragraph is to be read
        ///</summary>
        public object DrawingDirection => this._i.DrawingDirection;

        ///<summary>
        ///Specifies the direction in which the mtext paragraph is to be read
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
		public double Rotation => this._i.Rotation;

		///<summary>
		///
		///</summary>
		public void Set_Rotation(double rotAngle) 
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
        ///Specifies the latitude of the position marker
        ///</summary>
        public string Latitude => this._i.Latitude;

        ///<summary>
        ///Specifies the latitude of the position marker
        ///</summary>
        public void Set_Latitude(string Latitude) 
		{
			this._i.Latitude = Latitude;
		}

        ///<summary>
        ///Specifies the longitude of the position marker
        ///</summary>
        public string Longitude => this._i.Longitude;

        ///<summary>
        ///Specifies the longitude of the position marker
        ///</summary>
        public void Set_Longitude(string Longitude) 
		{
			this._i.Longitude = Longitude;
		}

        ///<summary>
        ///Specifies the elevation of the position marker
        ///</summary>
        public double Altitude => this._i.Altitude;

        ///<summary>
        ///Specifies the elevation of the position marker
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
