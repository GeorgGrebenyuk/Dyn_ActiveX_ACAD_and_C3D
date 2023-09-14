﻿using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadAttribute 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadAttribute _i;
		internal AcadAttribute(object AcadAttribute_object) 
		{
			this._i = AcadAttribute_object as Autodesk.AutoCAD.Interop.Common.AcadAttribute;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        ///<summary>
        /// Create new attribute
        ///</summary>
        public AcadAttribute (AcadBlock AcadBlock, double Height, 
			Autodesk.AutoCAD.Interop.Common.AcAttributeMode Mode, string Prompt, Point InsertionPoint, string Tag, string Value)
        {
            this._i = AcadBlock._i.AddAttribute(Height, Mode, Prompt, Technical.PointByDynPoint(InsertionPoint), Tag, Value);
        }

        ///<summary>
        ///
        ///</summary>
        public int FieldLength => this._i.FieldLength;

		///<summary>
		///
		///</summary>
		public void Set_FieldLength(dynamic fieldLen) 
		{
			this._i.FieldLength = fieldLen;
		}

		///<summary>
		///
		///</summary>
		public string TagString => this._i.TagString;

		///<summary>
		///
		///</summary>
		public void Set_TagString(string Tag) 
		{
			this._i.TagString = Tag;
		}

		///<summary>
		///
		///</summary>
		public string PromptString => this._i.PromptString;

		///<summary>
		///
		///</summary>
		public void Set_PromptString(string bstrPrompt) 
		{
			this._i.PromptString = bstrPrompt;
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
		public object Alignment => this._i.Alignment;

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
		public void Set_Rotation(dynamic rotAngle) 
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
		public int Mode => this._i.Mode;

		///<summary>
		///
		///</summary>
		public void Set_Mode(int Mode) 
		{
			this._i.Mode = Mode;
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
		public void Set_Constant(bool bConstant) 
		{
			this._i.Constant = bConstant;
		}

		///<summary>
		///
		///</summary>
		public bool Verify => this._i.Verify;

		///<summary>
		///
		///</summary>
		public void Set_Verify(bool bVerify) 
		{
			this._i.Verify = bVerify;
		}

		///<summary>
		///
		///</summary>
		public bool Preset => this._i.Preset;

		///<summary>
		///
		///</summary>
		public void Set_Preset(bool bPreset) 
		{
			this._i.Preset = bPreset;
		}

		///<summary>
		///
		///</summary>
		public bool LockPosition => this._i.LockPosition;

		///<summary>
		///
		///</summary>
		public void Set_LockPosition(bool bLockPosition) 
		{
			this._i.LockPosition = bLockPosition;
		}

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