namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadAttributeReference 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadAttributeReference _i;
		internal AcadAttributeReference(object AcadAttributeReference_object) 
		{
			this._i = AcadAttributeReference_object as Autodesk.AutoCAD.Interop.Common.IAcadAttributeReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
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
		public dynamic HorizontalAlignment => this._i.HorizontalAlignment;

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
		public object InsertionPoint => this._i.InsertionPoint;

		///<summary>
		///
		///</summary>
		public void Set_InsertionPoint(object insPoint) 
		{
			this._i.InsertionPoint = insPoint;
		}

		///<summary>
		///
		///</summary>
		public object Normal => this._i.Normal;

		///<summary>
		///
		///</summary>
		public void Set_Normal(object Normal) 
		{
			this._i.Normal = Normal;
		}

		///<summary>
		///
		///</summary>
		public double ObliqueAngle => this._i.ObliqueAngle;

		///<summary>
		///
		///</summary>
		public void Set_ObliqueAngle(double obliAngle) 
		{
			this._i.ObliqueAngle = obliAngle;
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
		public double ScaleFactor => this._i.ScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ScaleFactor(double scalFactor) 
		{
			this._i.ScaleFactor = scalFactor;
		}

		///<summary>
		///
		///</summary>
		public string StyleName => this._i.StyleName;

		///<summary>
		///
		///</summary>
		public void Set_StyleName(string Name) 
		{
			this._i.StyleName = Name;
		}

		///<summary>
		///
		///</summary>
		public string TagString => this._i.TagString;

		///<summary>
		///
		///</summary>
		public void Set_TagString(string bstrTag) 
		{
			this._i.TagString = bstrTag;
		}

		///<summary>
		///
		///</summary>
		public object TextAlignmentPoint => this._i.TextAlignmentPoint;

		///<summary>
		///
		///</summary>
		public void Set_TextAlignmentPoint(object alignPoint) 
		{
			this._i.TextAlignmentPoint = alignPoint;
		}

		///<summary>
		///
		///</summary>
		public int TextGenerationFlag => this._i.TextGenerationFlag;

		///<summary>
		///
		///</summary>
		public void Set_TextGenerationFlag(int textGenFlag) 
		{
			this._i.TextGenerationFlag = textGenFlag;
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
		public double Thickness => this._i.Thickness;

		///<summary>
		///
		///</summary>
		public void Set_Thickness(double Thickness) 
		{
			this._i.Thickness = Thickness;
		}

		///<summary>
		///
		///</summary>
		public dynamic VerticalAlignment => this._i.VerticalAlignment;

		///<summary>
		///
		///</summary>
		public void Set_VerticalAlignment(Autodesk.AutoCAD.Interop.Common.AcVerticalAlignment vertiAlign) 
		{
			this._i.VerticalAlignment = vertiAlign;
		}

		///<summary>
		///
		///</summary>
		public int FieldLength => this._i.FieldLength;

		///<summary>
		///
		///</summary>
		public void Set_FieldLength(int fieldLen) 
		{
			this._i.FieldLength = fieldLen;
		}

		///<summary>
		///
		///</summary>
		public dynamic Alignment => this._i.Alignment;

		///<summary>
		///
		///</summary>
		public void Set_Alignment(Autodesk.AutoCAD.Interop.Common.AcAlignment align) 
		{
			this._i.Alignment = align;
		}

		///<summary>
		///
		///</summary>
		public bool UpsideDown => this._i.UpsideDown;

		///<summary>
		///
		///</summary>
		public void Set_UpsideDown(bool bUpsideDown) 
		{
			this._i.UpsideDown = bUpsideDown;
		}

		///<summary>
		///
		///</summary>
		public bool Backward => this._i.Backward;

		///<summary>
		///
		///</summary>
		public void Set_Backward(bool bBackward) 
		{
			this._i.Backward = bBackward;
		}

		///<summary>
		///
		///</summary>
		public bool Invisible => this._i.Invisible;

		///<summary>
		///
		///</summary>
		public void Set_Invisible(bool bInvisible) 
		{
			this._i.Invisible = bInvisible;
		}

		///<summary>
		///
		///</summary>
		public bool Constant => this._i.Constant;

		///<summary>
		///
		///</summary>
		public bool LockPosition => this._i.LockPosition;

		///<summary>
		///
		///</summary>
		public bool MTextAttribute => this._i.MTextAttribute;

		///<summary>
		///
		///</summary>
		public void Set_MTextAttribute(bool bMTextAttribute) 
		{
			this._i.MTextAttribute = bMTextAttribute;
		}

		///<summary>
		///
		///</summary>
		public string MTextAttributeContent => this._i.MTextAttributeContent;

		///<summary>
		///
		///</summary>
		public void Set_MTextAttributeContent(string content) 
		{
			this._i.MTextAttributeContent = content;
		}

		///<summary>
		///
		///</summary>
		public void UpdateMTextAttribute() 
		{
			this._i.UpdateMTextAttribute();
		}

		///<summary>
		///
		///</summary>
		public double MTextBoundaryWidth => this._i.MTextBoundaryWidth;

		///<summary>
		///
		///</summary>
		public void Set_MTextBoundaryWidth(double MTextBoundaryWidth) 
		{
			this._i.MTextBoundaryWidth = MTextBoundaryWidth;
		}

		///<summary>
		///
		///</summary>
		public dynamic MTextDrawingDirection => this._i.MTextDrawingDirection;

		///<summary>
		///
		///</summary>
		public void Set_MTextDrawingDirection(Autodesk.AutoCAD.Interop.Common.AcDrawingDirection drawDir) 
		{
			this._i.MTextDrawingDirection = drawDir;
		}
	}
}
