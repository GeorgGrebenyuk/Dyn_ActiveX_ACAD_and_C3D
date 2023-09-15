using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadTolerance 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadTolerance _i;
		internal AcadTolerance(object AcadTolerance_object) 
		{
			this._i = AcadTolerance_object as Autodesk.AutoCAD.Interop.Common.AcadTolerance;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadTolerance(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadTolerance;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }
        ///<summary>
        /// Create new Tolerance
        ///</summary>
        public AcadTolerance(AcadBlock AcadBlock, string Text, Point InsertionPoint, Vector Direction)
        {
            this._i =  AcadBlock._i.AddTolerance(Text, Technical.PointByDynPoint(InsertionPoint),
				Technical.VectorByDynVector(Direction));
        }

        ///<summary>
        ///
        ///</summary>
        public object DirectionVector => this._i.DirectionVector;

		///<summary>
		///
		///</summary>
		public void Set_DirectionVector(object dirVector) 
		{
			this._i.DirectionVector = dirVector;
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
		public dynamic TextColor => this._i.TextColor;

		///<summary>
		///
		///</summary>
		public void Set_TextColor(dynamic color) 
		{
			this._i.TextColor = color;
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
		public string TextStyle => this._i.TextStyle;

		///<summary>
		///
		///</summary>
		public void Set_TextStyle(string style) 
		{
			this._i.TextStyle = style;
		}

		///<summary>
		///
		///</summary>
		public double TextHeight => this._i.TextHeight;

		///<summary>
		///
		///</summary>
		public void Set_TextHeight(double Height) 
		{
			this._i.TextHeight = Height;
		}

		///<summary>
		///
		///</summary>
		public dynamic ScaleFactor => this._i.ScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ScaleFactor(dynamic factor) 
		{
			this._i.ScaleFactor = factor;
		}

		///<summary>
		///
		///</summary>
		public dynamic DimensionLineColor => this._i.DimensionLineColor;

		///<summary>
		///
		///</summary>
		public void Set_DimensionLineColor(dynamic Type) 
		{
			this._i.DimensionLineColor = Type;
		}
	}
}
