using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadDim3PointAngular 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadDim3PointAngular _i;
		internal AcadDim3PointAngular(object AcadDim3PointAngular_object) 
		{
			this._i = AcadDim3PointAngular_object as Autodesk.AutoCAD.Interop.Common.AcadDim3PointAngular;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadDim3PointAngular(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadDim3PointAngular;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }


        ///<summary>
        /// Create new Dim3PointAngular
        ///</summary>
        public AcadDim3PointAngular (AcadBlock AcadBlock, Point AngleVertex,
			Point FirstEndPoint, Point SecondEndPoint, Point TextPoint)
        {
            this._i =  AcadBlock._i.AddDim3PointAngular(Technical.PointByDynPoint(AngleVertex),
                Technical.PointByDynPoint(FirstEndPoint), Technical.PointByDynPoint(SecondEndPoint),
                Technical.PointByDynPoint(TextPoint));
        }

        ///<summary>
        ///
        ///</summary>
        public Point ExtLine1EndPoint => Technical.PointByDynPoint(this._i.ExtLine1EndPoint);

		///<summary>
		///
		///</summary>
		public void Set_ExtLine1EndPoint(Point xLine1Point) 
		{
			this._i.ExtLine1EndPoint = Technical.PointByDoubleArray(xLine1Point);
		}

		///<summary>
		///
		///</summary>
		public Point ExtLine2EndPoint => Technical.PointByDynPoint(this._i.ExtLine2EndPoint);

		///<summary>
		///
		///</summary>
		public void Set_ExtLine2EndPoint(Point xLine2Point) 
		{
			this._i.ExtLine2EndPoint = Technical.PointByDoubleArray(xLine2Point);
		}

		///<summary>
		///
		///</summary>
		public Point AngleVertex => Technical.PointByDoubleArray(this._i.AngleVertex);

		///<summary>
		///
		///</summary>
		public void Set_AngleVertex(Point AngleVertex) 
		{
			this._i.AngleVertex = Technical.PointByDynPoint(AngleVertex);
		}

		///<summary>
		///
		///</summary>
		public object TextPrecision => this._i.TextPrecision;

		///<summary>
		///
		///</summary>
		public void Set_TextPrecision(Autodesk.AutoCAD.Interop.Common.AcDimPrecision AngleVertex) 
		{
			this._i.TextPrecision = AngleVertex;
		}

		///<summary>
		///
		///</summary>
		public object AngleFormat => this._i.AngleFormat;

		///<summary>
		///
		///</summary>
		public void Set_AngleFormat(Autodesk.AutoCAD.Interop.Common.AcAngleUnits format) 
		{
			this._i.AngleFormat = format;
		}

		///<summary>
		///
		///</summary>
		public object DimensionLineColor => this._i.DimensionLineColor;

		///<summary>
		///
		///</summary>
		public void Set_DimensionLineColor(dynamic Type) 
		{
			this._i.DimensionLineColor = Type;
		}

		///<summary>
		///
		///</summary>
		public object ExtensionLineColor => this._i.ExtensionLineColor;

		///<summary>
		///
		///</summary>
		public void Set_ExtensionLineColor(dynamic Type) 
		{
			this._i.ExtensionLineColor = Type;
		}

		///<summary>
		///
		///</summary>
		public double ExtensionLineExtend => this._i.ExtensionLineExtend;

		///<summary>
		///
		///</summary>
		public void Set_ExtensionLineExtend(double extend) 
		{
			this._i.ExtensionLineExtend = extend;
		}

		///<summary>
		///
		///</summary>
		public object Fit => this._i.Fit;

		///<summary>
		///
		///</summary>
		public void Set_Fit(Autodesk.AutoCAD.Interop.Common.AcDimFit fittype) 
		{
			this._i.Fit = fittype;
		}

		///<summary>
		///
		///</summary>
		public object HorizontalTextPosition => this._i.HorizontalTextPosition;

		///<summary>
		///
		///</summary>
		public void Set_HorizontalTextPosition(Autodesk.AutoCAD.Interop.Common.AcDimHorizontalJustification Type) 
		{
			this._i.HorizontalTextPosition = Type;
		}

		///<summary>
		///
		///</summary>
		public object ExtensionLineWeight => this._i.ExtensionLineWeight;

		///<summary>
		///
		///</summary>
		public void Set_ExtensionLineWeight(dynamic lweight) 
		{
			this._i.ExtensionLineWeight = lweight;
		}

		///<summary>
		///
		///</summary>
		public bool DimLine1Suppress => this._i.DimLine1Suppress;

		///<summary>
		///
		///</summary>
		public void Set_DimLine1Suppress(bool bSuppress) 
		{
			this._i.DimLine1Suppress = bSuppress;
		}

		///<summary>
		///
		///</summary>
		public bool DimLine2Suppress => this._i.DimLine2Suppress;

		///<summary>
		///
		///</summary>
		public void Set_DimLine2Suppress(bool bSuppress) 
		{
			this._i.DimLine2Suppress = bSuppress;
		}

		///<summary>
		///
		///</summary>
		public bool ExtLine1Suppress => this._i.ExtLine1Suppress;

		///<summary>
		///
		///</summary>
		public void Set_ExtLine1Suppress(bool bSuppress) 
		{
			this._i.ExtLine1Suppress = bSuppress;
		}

		///<summary>
		///
		///</summary>
		public bool ExtLine2Suppress => this._i.ExtLine2Suppress;

		///<summary>
		///
		///</summary>
		public void Set_ExtLine2Suppress(bool bSuppress) 
		{
			this._i.ExtLine2Suppress = bSuppress;
		}

		///<summary>
		///
		///</summary>
		public bool DimLineInside => this._i.DimLineInside;

		///<summary>
		///
		///</summary>
		public void Set_DimLineInside(bool bInside) 
		{
			this._i.DimLineInside = bInside;
		}

		///<summary>
		///
		///</summary>
		public bool TextInsideAlign => this._i.TextInsideAlign;

		///<summary>
		///
		///</summary>
		public void Set_TextInsideAlign(bool bInside) 
		{
			this._i.TextInsideAlign = bInside;
		}

		///<summary>
		///
		///</summary>
		public bool TextInside => this._i.TextInside;

		///<summary>
		///
		///</summary>
		public void Set_TextInside(bool bInside) 
		{
			this._i.TextInside = bInside;
		}

		///<summary>
		///
		///</summary>
		public bool ForceLineInside => this._i.ForceLineInside;

		///<summary>
		///
		///</summary>
		public void Set_ForceLineInside(bool bInside) 
		{
			this._i.ForceLineInside = bInside;
		}

		///<summary>
		///
		///</summary>
		public bool TextOutsideAlign => this._i.TextOutsideAlign;

		///<summary>
		///
		///</summary>
		public void Set_TextOutsideAlign(bool bInside) 
		{
			this._i.TextOutsideAlign = bInside;
		}

		///<summary>
		///
		///</summary>
		public double ExtensionLineOffset => this._i.ExtensionLineOffset;

		///<summary>
		///
		///</summary>
		public void Set_ExtensionLineOffset(double Offset) 
		{
			this._i.ExtensionLineOffset = Offset;
		}

		///<summary>
		///
		///</summary>
		public object DimensionLineWeight => this._i.DimensionLineWeight;

		///<summary>
		///
		///</summary>
		public void Set_DimensionLineWeight(dynamic weight) 
		{
			this._i.DimensionLineWeight = weight;
		}

		///<summary>
		///
		///</summary>
		public double ArrowheadSize => this._i.ArrowheadSize;

		///<summary>
		///
		///</summary>
		public void Set_ArrowheadSize(double size) 
		{
			this._i.ArrowheadSize = size;
		}

		///<summary>
		///
		///</summary>
		public object Arrowhead1Type => this._i.Arrowhead1Type;

		///<summary>
		///
		///</summary>
		public void Set_Arrowhead1Type(Autodesk.AutoCAD.Interop.Common.AcDimArrowheadType Type) 
		{
			this._i.Arrowhead1Type = Type;
		}

		///<summary>
		///
		///</summary>
		public object Arrowhead2Type => this._i.Arrowhead2Type;

		///<summary>
		///
		///</summary>
		public void Set_Arrowhead2Type(Autodesk.AutoCAD.Interop.Common.AcDimArrowheadType Type) 
		{
			this._i.Arrowhead2Type = Type;
		}

		///<summary>
		///
		///</summary>
		public double Measurement => this._i.Measurement;

		///<summary>
		///
		///</summary>
		public string Arrowhead1Block => this._i.Arrowhead1Block;

		///<summary>
		///
		///</summary>
		public void Set_Arrowhead1Block(string BlockName) 
		{
			this._i.Arrowhead1Block = BlockName;
		}

		///<summary>
		///
		///</summary>
		public string Arrowhead2Block => this._i.Arrowhead2Block;

		///<summary>
		///
		///</summary>
		public void Set_Arrowhead2Block(string BlockName) 
		{
			this._i.Arrowhead2Block = BlockName;
		}

		///<summary>
		///
		///</summary>
		public string DimensionLinetype => this._i.DimensionLinetype;

		///<summary>
		///
		///</summary>
		public void Set_DimensionLinetype(string Linetype) 
		{
			this._i.DimensionLinetype = Linetype;
		}

		///<summary>
		///
		///</summary>
		public string ExtLine1Linetype => this._i.ExtLine1Linetype;

		///<summary>
		///
		///</summary>
		public void Set_ExtLine1Linetype(string Linetype) 
		{
			this._i.ExtLine1Linetype = Linetype;
		}

		///<summary>
		///
		///</summary>
		public string ExtLine2Linetype => this._i.ExtLine2Linetype;

		///<summary>
		///
		///</summary>
		public void Set_ExtLine2Linetype(string Linetype) 
		{
			this._i.ExtLine2Linetype = Linetype;
		}

		///<summary>
		///
		///</summary>
		public bool ExtLineFixedLenSuppress => this._i.ExtLineFixedLenSuppress;

		///<summary>
		///
		///</summary>
		public void Set_ExtLineFixedLenSuppress(bool bFixedLen) 
		{
			this._i.ExtLineFixedLenSuppress = bFixedLen;
		}

		///<summary>
		///
		///</summary>
		public double ExtLineFixedLen => this._i.ExtLineFixedLen;

		///<summary>
		///
		///</summary>
		public void Set_ExtLineFixedLen(double FixedLen) 
		{
			this._i.ExtLineFixedLen = FixedLen;
		}

		///<summary>
		///
		///</summary>
		public bool DimConstrForm => this._i.DimConstrForm;

		///<summary>
		///
		///</summary>
		public void Set_DimConstrForm(bool bIsDynamic) 
		{
			this._i.DimConstrForm = bIsDynamic;
		}

		///<summary>
		///
		///</summary>
		public bool DimConstrReference => this._i.DimConstrReference;

		///<summary>
		///
		///</summary>
		public void Set_DimConstrReference(bool bIsReference) 
		{
			this._i.DimConstrReference = bIsReference;
		}

		///<summary>
		///
		///</summary>
		public string DimConstrName => this._i.DimConstrName;

		///<summary>
		///
		///</summary>
		public void Set_DimConstrName(string bstrName) 
		{
			this._i.DimConstrName = bstrName;
		}

		///<summary>
		///
		///</summary>
		public string DimConstrExpression => this._i.DimConstrExpression;

		///<summary>
		///
		///</summary>
		public void Set_DimConstrExpression(string bstrExpression) 
		{
			this._i.DimConstrExpression = bstrExpression;
		}

		///<summary>
		///
		///</summary>
		public string DimConstrValue => this._i.DimConstrValue;

		///<summary>
		///
		///</summary>
		public void Set_DimConstrValue(string Value) 
		{
			this._i.DimConstrValue = Value;
		}

		///<summary>
		///
		///</summary>
		public string DimConstrDesc => this._i.DimConstrDesc;

		///<summary>
		///
		///</summary>
		public void Set_DimConstrDesc(string bstrDescription) 
		{
			this._i.DimConstrDesc = bstrDescription;
		}
	}
}
