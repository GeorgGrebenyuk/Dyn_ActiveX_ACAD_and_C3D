using Autodesk.DesignScript.Geometry;
namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadText 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadText _i;
		internal AcadText(object AcadText_object) 
		{
			this._i = AcadText_object as Autodesk.AutoCAD.Interop.Common.IAcadText;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadText (AcadEntity AcadEntity)
		{
			this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.IAcadText;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }
		/// <summary>
		/// Create new text
		/// </summary>
		/// <param name="AcadBlock"></param>
		/// <param name="TextString"></param>
		/// <param name="InsertionPoint"></param>
		/// <param name="Height"></param>
		public AcadText (AcadBlock AcadBlock, string TextString, Point InsertionPoint, double Height)
		{
            this._i = AcadBlock._i.AddText(TextString, Technical.PointByDynPoint(InsertionPoint), Height);
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
		public void Set_StyleName(string bstrName) 
		{
			this._i.StyleName = bstrName;
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
		public dynamic ScaleFactor => this._i.ScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ScaleFactor(dynamic scalFactor) 
		{
			this._i.ScaleFactor = scalFactor;
		}

		///<summary>
		///
		///</summary>
		public dynamic ObliqueAngle => this._i.ObliqueAngle;

		///<summary>
		///
		///</summary>
		public void Set_ObliqueAngle(dynamic obliAngle) 
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
		public dynamic TextGenerationFlag => this._i.TextGenerationFlag;

		///<summary>
		///
		///</summary>
		public void Set_TextGenerationFlag(dynamic textGenFlag) 
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
		public bool UpsideDown => this._i.UpsideDown;

		///<summary>
		///
		///</summary>
		public void Set_UpsideDown(bool UpsideDown) 
		{
			this._i.UpsideDown = UpsideDown;
		}

		///<summary>
		///
		///</summary>
		public bool Backward => this._i.Backward;

		///<summary>
		///
		///</summary>
		public void Set_Backward(bool Backward) 
		{
			this._i.Backward = Backward;
		}

		///<summary>
		///
		///</summary>
		public string FieldCode => this._i.FieldCode();
	}
}
