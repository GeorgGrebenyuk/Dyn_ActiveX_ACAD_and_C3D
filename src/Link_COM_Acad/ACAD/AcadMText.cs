using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

    ///<summary>
    /// A paragraph of alphanumeric characters that fits within a nonprinting text boundary. MText objects use word wrap to break long lines into paragraphs. AutoCAD automatically breaks lines at the edge of the text boundary, as specified by the Width property. 


    ///</summary>
    public class AcadMText 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadMText _i;
		internal AcadMText(object AcadMText_object) 
		{
			this._i = AcadMText_object as Autodesk.AutoCAD.Interop.Common.AcadMText;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadMText(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadMText;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        /// <summary>
        /// Creates an MText entity in a rectangle defined by the insertion point and width of the bounding box
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="InsertionPoint">The insertion point of the MText bounding box</param>
        /// <param name="Width">The width of the MText bounding box</param>
        /// <param name="Text">The actual text string for the MText object</param>
        public AcadMText(AcadBlock AcadBlock, Point InsertionPoint, double Width, string Text)
        {
            this._i = AcadBlock._i.AddMText(Technical.PointByDynPoint(InsertionPoint), Width, Text);
        }


        ///<summary>
        /// Specifies the text string for the entity
        ///</summary>
        public string TextString => this._i.TextString;

        ///<summary>
        /// Specifies the text string for the entity
        ///</summary>
        public void Set_TextString(string bstrText) 
		{
			this._i.TextString = bstrText;
		}

        ///<summary>
        /// Specifies the name of the style used with the object
        ///</summary>
        public string StyleName => this._i.StyleName;

        ///<summary>
        /// Specifies the name of the style used with the object
        ///</summary>
        public void Set_StyleName(string bstrName) 
		{
			this._i.StyleName = bstrName;
		}

		///<summary>
		///
		///</summary>
		public dynamic AttachmentPoint => this._i.AttachmentPoint;

		///<summary>
		///
		///</summary>
		public void Set_AttachmentPoint(Autodesk.AutoCAD.Interop.Common.AcAttachmentPoint attPoint) 
		{
			this._i.AttachmentPoint = attPoint;
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
		public double Width => this._i.Width;

		///<summary>
		///
		///</summary>
		public void Set_Width(double Width) 
		{
			this._i.Width = Width;
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
		public object InsertionPoint => this._i.InsertionPoint;

		///<summary>
		///
		///</summary>
		public void Set_InsertionPoint(object insPoint) 
		{
			this._i.InsertionPoint = insPoint;
		}

        ///<summary>
        /// Get the Normal vector from that object
        ///</summary>
        public Vector Normal => Technical.VectorByDoubleArray(this._i.Normal);

        ///<summary>
        /// Set Normal to that object by Dynamo vector
        ///</summary>
        public void Set_Normal(Vector Normal)
        {
            this._i.Normal = Technical.VectorByDynVector(Normal);
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
		public string FieldCode => this._i.FieldCode();
	}
}
