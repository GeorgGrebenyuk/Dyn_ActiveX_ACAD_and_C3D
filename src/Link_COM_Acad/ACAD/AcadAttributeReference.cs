using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

    ///<summary>
    ///An object containing text that links to a block. You cannot directly create an attribute reference. Attribute references are added to the drawing when a block containing an attribute definition is inserted into the drawing. To access an attribute reference of an inserted block, use the GetAttributes method. This method returns an array of all attribute references attached to the inserted block
    ///</summary>
    public class AcadAttributeReference 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadAttributeReference _i;
		internal AcadAttributeReference(object AcadAttributeReference_object) 
		{
			this._i = AcadAttributeReference_object as Autodesk.AutoCAD.Interop.Common.AcadAttributeReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

        ///<summary>
        ///Specifies the field length of the attribute
        ///</summary>
        public int FieldLength => this._i.FieldLength;

        ///<summary>
        ///Specifies the field length of the attribute
        ///</summary>
        public void Set_FieldLength(int fieldLen)
        {
            this._i.FieldLength = fieldLen;
        }

        ///<summary>
        ///Specifies the tag string of the object
        ///</summary>
        public string TagString => this._i.TagString;

        ///<summary>
        ///Specifies the tag string of the object
        ///</summary>
        public void Set_TagString(string Tag)
        {
            this._i.TagString = Tag;
        }

        ///<summary>
        ///Specifies the text string for the entity
        ///</summary>
        public string TextString => this._i.TextString;

        ///<summary>
        ///Specifies the text string for the entity
        ///</summary>
        public void Set_TextString(string bstrText)
        {
            this._i.TextString = bstrText;
        }

        ///<summary>
        ///Specifies the name of the style used with the object
        ///</summary>
        public string StyleName => this._i.StyleName;

        ///<summary>
        ///Specifies the name of the style used with the object
        ///</summary>
        public void Set_StyleName(string Name)
        {
            this._i.StyleName = Name;
        }

        ///<summary>
        ///Specifies both the vertical and horizontal alignments for the attribute
        ///</summary>
        public object Alignment => this._i.Alignment;

        ///<summary>
        ///Specifies both the vertical and horizontal alignments for the attribute
        ///</summary>
        public void Set_Alignment(Autodesk.AutoCAD.Interop.Common.AcAlignment align)
        {
            this._i.Alignment = align;
        }

        ///<summary>
        ///
        ///</summary>
        public object HorizontalAlignment => this._i.HorizontalAlignment;

        ///<summary>
        ///
        ///</summary>
        public void Set_HorizontalAlignment(Autodesk.AutoCAD.Interop.Common.AcHorizontalAlignment horizAlign)
        {
            this._i.HorizontalAlignment = horizAlign;
        }

        ///<summary>
        ///
        ///</summary>
        public object VerticalAlignment => this._i.VerticalAlignment;

        ///<summary>
        ///
        ///</summary>
        public void Set_VerticalAlignment(Autodesk.AutoCAD.Interop.Common.AcVerticalAlignment vertiAlign)
        {
            this._i.VerticalAlignment = vertiAlign;
        }

        ///<summary>
        ///Changes the height of the object
        ///</summary>
        public double Height => this._i.Height;

        ///<summary>
        ///Changes the height of the object
        ///</summary>
        public void Set_Height(double Height)
        {
            this._i.Height = Height;
        }

        ///<summary>
        ///Specifies the rotation angle for the object
        ///</summary>
        public double Rotation => this._i.Rotation;

        ///<summary>
        ///Specifies the rotation angle for the object
        ///</summary>
        public void Set_Rotation(dynamic rotAngle)
        {
            this._i.Rotation = rotAngle;
        }

        ///<summary>
        ///Specifies the scale factor for the object
        ///</summary>
        public double ScaleFactor => this._i.ScaleFactor;

        ///<summary>
        ///Specifies the scale factor for the object
        ///</summary>
        public void Set_ScaleFactor(double scalFactor)
        {
            this._i.ScaleFactor = scalFactor;
        }

        ///<summary>
        ///Specifies the oblique angle of the object
        ///</summary>
        public double ObliqueAngle => this._i.ObliqueAngle;

        ///<summary>
        ///Specifies the oblique angle of the object
        ///</summary>
        public void Set_ObliqueAngle(double obliAngle)
        {
            this._i.ObliqueAngle = obliAngle;
        }

        ///<summary>
        ///Specifies the alignment point for text and attributes
        ///</summary>
        public Point TextAlignmentPoint => Technical.PointByDoubleArray(this._i.TextAlignmentPoint);

        ///<summary>
        ///Specifies the alignment point for text and attributes
        ///</summary>
        public void Set_TextAlignmentPoint(Point alignPoint)
        {
            this._i.TextAlignmentPoint = Technical.PointByDynPoint(alignPoint);
        }

        ///<summary>
        ///Insertion point for a object
        ///</summary>
        public Point InsertionPoint => Technical.PointByDoubleArray(this._i.InsertionPoint);

        ///<summary>
        ///Insertion point for a object
        ///</summary>
        public void Set_InsertionPoint(Point insPoint)
        {
            this._i.InsertionPoint = Technical.PointByDynPoint(insPoint);
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
        ///Specifies the attribute text generation flag
        ///</summary>
        public int TextGenerationFlag => this._i.TextGenerationFlag;

        ///<summary>
        ///Specifies the attribute text generation flag
        ///</summary>
        public void Set_TextGenerationFlag(int textGenFlag)
        {
            this._i.TextGenerationFlag = textGenFlag;
        }

        ///<summary>
        ///Specifies the distance a 2D AutoCAD object is extruded above or below its elevation
        ///</summary>
        public double Thickness => this._i.Thickness;

        ///<summary>
        ///Specifies the distance a 2D AutoCAD object is extruded above or below its elevation
        ///</summary>
        public void Set_Thickness(double Thickness)
        {
            this._i.Thickness = Thickness;
        }

        ///<summary>
        ///Specifies the direction of text
        ///</summary>
        public bool UpsideDown => this._i.UpsideDown;

        ///<summary>
        ///Specifies the direction of text
        ///</summary>
        public void Set_UpsideDown(bool bUpsideDown)
        {
            this._i.UpsideDown = bUpsideDown;
        }

        ///<summary>
        ///Specifies the direction of text
        ///</summary>
        public bool Backward => this._i.Backward;

        ///<summary>
        ///Specifies the direction of text
        ///</summary>
        public void Set_Backward(bool bBackward)
        {
            this._i.Backward = bBackward;
        }

        ///<summary>
        ///Specifies whether the attribute or attribute reference is invisible
        ///</summary>
        public bool Invisible => this._i.Invisible;

        ///<summary>
        ///Specifies whether the attribute or attribute reference is invisible
        ///</summary>
        public void Set_Invisible(bool bInvisible)
        {
            this._i.Invisible = bInvisible;
        }

        ///<summary>
        ///Specifies whether the attribute or attribute reference is constant or not
        ///</summary>
        public bool Constant => this._i.Constant;



        ///<summary>
        ///Specifies whether the attribute or attribute reference may be moved relative to the geometry in the block
        ///</summary>
        public bool LockPosition => this._i.LockPosition;

        ///<summary>
        ///Determines if the attribute is multiline
        ///</summary>
        public bool MTextAttribute => this._i.MTextAttribute;

        ///<summary>
        ///Determines if the attribute is multiline
        ///</summary>
        public void Set_MTextAttribute(bool bMTextAttribute)
        {
            this._i.MTextAttribute = bMTextAttribute;
        }

        ///<summary>
        ///Gets the multiline attribute content
        ///</summary>
        public string MTextAttributeContent => this._i.MTextAttributeContent;

        ///<summary>
        ///Gets the multiline attribute content
        ///</summary>
        public void Set_MTextAttributeContent(string content)
        {
            this._i.MTextAttributeContent = content;
        }

        ///<summary>
        ///Updates attribute from the multiline text and multiline text from an attribute
        ///</summary>
        public void UpdateMTextAttribute()
        {
            this._i.UpdateMTextAttribute();
        }

        ///<summary>
        ///Determines the width of the text boundary for the multiline attribute
        ///</summary>
        public double MTextBoundaryWidth => this._i.MTextBoundaryWidth;

        ///<summary>
        ///Determines the width of the text boundary for the multiline attribute
        ///</summary>
        public void Set_MTextBoundaryWidth(double MTextBoundaryWidth)
        {
            this._i.MTextBoundaryWidth = MTextBoundaryWidth;
        }

        ///<summary>
        ///Determines the drawing direction for the multiline attribute
        ///</summary>
        public object MTextDrawingDirection => this._i.MTextDrawingDirection;

        ///<summary>
        ///Determines the drawing direction for the multiline attribute
        ///</summary>
        public void Set_MTextDrawingDirection(Autodesk.AutoCAD.Interop.Common.AcDrawingDirection drawDir)
        {
            this._i.MTextDrawingDirection = drawDir;
        }
    }
}
