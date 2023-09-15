using Autodesk.DesignScript.Geometry;
using System;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadDimArcLength 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadDimArcLength _i;
		internal AcadDimArcLength(object AcadDimArcLength_object) 
		{
			this._i = AcadDimArcLength_object as Autodesk.AutoCAD.Interop.Common.AcadDimArcLength;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadDimArcLength(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadDimArcLength;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        ///<summary>
        /// Create new DimArcLength
        ///</summary>
        public AcadDimArcLength(AcadBlock AcadBlock, Point ArcCenter,
            Point FirstEndPoint, Point SecondEndPoint, Point ArcPoint)
        {
            this._i =  AcadBlock._i.AddDimArc(Technical.PointByDynPoint(ArcCenter),
                Technical.PointByDynPoint(FirstEndPoint), Technical.PointByDynPoint(SecondEndPoint),
                Technical.PointByDynPoint(ArcPoint));
        }
        ///<summary>
        ///
        ///</summary>
        public bool AltUnits => this._i.AltUnits;

		///<summary>
		///
		///</summary>
		public void Set_AltUnits(bool bAlternate) 
		{
			this._i.AltUnits = bAlternate;
		}

		///<summary>
		///
		///</summary>
		public dynamic AltUnitsPrecision => this._i.AltUnitsPrecision;

		///<summary>
		///
		///</summary>
		public void Set_AltUnitsPrecision(Autodesk.AutoCAD.Interop.Common.AcDimPrecision precision) 
		{
			this._i.AltUnitsPrecision = precision;
		}

		///<summary>
		///
		///</summary>
		public dynamic AltUnitsScale => this._i.AltUnitsScale;

		///<summary>
		///
		///</summary>
		public void Set_AltUnitsScale(dynamic scale) 
		{
			this._i.AltUnitsScale = scale;
		}

		///<summary>
		///
		///</summary>
		public double AltRoundDistance => this._i.AltRoundDistance;

		///<summary>
		///
		///</summary>
		public void Set_AltRoundDistance(double Distance) 
		{
			this._i.AltRoundDistance = Distance;
		}

		///<summary>
		///
		///</summary>
		public dynamic AltTolerancePrecision => this._i.AltTolerancePrecision;

		///<summary>
		///
		///</summary>
		public void Set_AltTolerancePrecision(Autodesk.AutoCAD.Interop.Common.AcDimPrecision Distance) 
		{
			this._i.AltTolerancePrecision = Distance;
		}

		///<summary>
		///
		///</summary>
		public dynamic AltUnitsFormat => this._i.AltUnitsFormat;

		///<summary>
		///
		///</summary>
		public void Set_AltUnitsFormat(Autodesk.AutoCAD.Interop.Common.AcDimUnits Units) 
		{
			this._i.AltUnitsFormat = Units;
		}

		///<summary>
		///
		///</summary>
		public string AltTextPrefix => this._i.AltTextPrefix;

		///<summary>
		///
		///</summary>
		public void Set_AltTextPrefix(string prefix) 
		{
			this._i.AltTextPrefix = prefix;
		}

		///<summary>
		///
		///</summary>
		public string AltTextSuffix => this._i.AltTextSuffix;

		///<summary>
		///
		///</summary>
		public void Set_AltTextSuffix(string prefix) 
		{
			this._i.AltTextSuffix = prefix;
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

		///<summary>
		///
		///</summary>
		public dynamic ExtensionLineColor => this._i.ExtensionLineColor;

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
		public dynamic PrimaryUnitsPrecision => this._i.PrimaryUnitsPrecision;

		///<summary>
		///
		///</summary>
		public void Set_PrimaryUnitsPrecision(Autodesk.AutoCAD.Interop.Common.AcDimPrecision Prec) 
		{
			this._i.PrimaryUnitsPrecision = Prec;
		}

		///<summary>
		///
		///</summary>
		public double DimensionLineExtend => this._i.DimensionLineExtend;

		///<summary>
		///
		///</summary>
		public void Set_DimensionLineExtend(double extend) 
		{
			this._i.DimensionLineExtend = extend;
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
		public dynamic Fit => this._i.Fit;

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
		public dynamic FractionFormat => this._i.FractionFormat;

		///<summary>
		///
		///</summary>
		public void Set_FractionFormat(Autodesk.AutoCAD.Interop.Common.AcDimFractionType Type) 
		{
			this._i.FractionFormat = Type;
		}

		///<summary>
		///
		///</summary>
		public dynamic HorizontalTextPosition => this._i.HorizontalTextPosition;

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
		public dynamic LinearScaleFactor => this._i.LinearScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_LinearScaleFactor(dynamic Type) 
		{
			this._i.LinearScaleFactor = Type;
		}

		///<summary>
		///
		///</summary>
		public dynamic UnitsFormat => this._i.UnitsFormat;

		///<summary>
		///
		///</summary>
		public void Set_UnitsFormat(Autodesk.AutoCAD.Interop.Common.AcDimLUnits format) 
		{
			this._i.UnitsFormat = format;
		}

		///<summary>
		///
		///</summary>
		public dynamic ExtensionLineWeight => this._i.ExtensionLineWeight;

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
		public double RoundDistance => this._i.RoundDistance;

		///<summary>
		///
		///</summary>
		public void Set_RoundDistance(double Distance) 
		{
			this._i.RoundDistance = Distance;
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
		public bool AltSuppressLeadingZeros => this._i.AltSuppressLeadingZeros;

		///<summary>
		///
		///</summary>
		public void Set_AltSuppressLeadingZeros(bool bVal) 
		{
			this._i.AltSuppressLeadingZeros = bVal;
		}

		///<summary>
		///
		///</summary>
		public bool AltSuppressTrailingZeros => this._i.AltSuppressTrailingZeros;

		///<summary>
		///
		///</summary>
		public void Set_AltSuppressTrailingZeros(bool bVal) 
		{
			this._i.AltSuppressTrailingZeros = bVal;
		}

		///<summary>
		///
		///</summary>
		public bool AltSuppressZeroFeet => this._i.AltSuppressZeroFeet;

		///<summary>
		///
		///</summary>
		public void Set_AltSuppressZeroFeet(bool bVal) 
		{
			this._i.AltSuppressZeroFeet = bVal;
		}

		///<summary>
		///
		///</summary>
		public bool AltSuppressZeroInches => this._i.AltSuppressZeroInches;

		///<summary>
		///
		///</summary>
		public void Set_AltSuppressZeroInches(bool bVal) 
		{
			this._i.AltSuppressZeroInches = bVal;
		}

		///<summary>
		///
		///</summary>
		public bool AltToleranceSuppressLeadingZeros => this._i.AltToleranceSuppressLeadingZeros;

		///<summary>
		///
		///</summary>
		public void Set_AltToleranceSuppressLeadingZeros(bool bVal) 
		{
			this._i.AltToleranceSuppressLeadingZeros = bVal;
		}

		///<summary>
		///
		///</summary>
		public bool AltToleranceSuppressTrailingZeros => this._i.AltToleranceSuppressTrailingZeros;

		///<summary>
		///
		///</summary>
		public void Set_AltToleranceSuppressTrailingZeros(bool bVal) 
		{
			this._i.AltToleranceSuppressTrailingZeros = bVal;
		}

		///<summary>
		///
		///</summary>
		public bool AltToleranceSuppressZeroFeet => this._i.AltToleranceSuppressZeroFeet;

		///<summary>
		///
		///</summary>
		public void Set_AltToleranceSuppressZeroFeet(bool bVal) 
		{
			this._i.AltToleranceSuppressZeroFeet = bVal;
		}

		///<summary>
		///
		///</summary>
		public bool AltToleranceSuppressZeroInches => this._i.AltToleranceSuppressZeroInches;

		///<summary>
		///
		///</summary>
		public void Set_AltToleranceSuppressZeroInches(bool bVal) 
		{
			this._i.AltToleranceSuppressZeroInches = bVal;
		}

		///<summary>
		///
		///</summary>
		public bool SuppressZeroFeet => this._i.SuppressZeroFeet;

		///<summary>
		///
		///</summary>
		public void Set_SuppressZeroFeet(bool bVal) 
		{
			this._i.SuppressZeroFeet = bVal;
		}

		///<summary>
		///
		///</summary>
		public bool SuppressZeroInches => this._i.SuppressZeroInches;

		///<summary>
		///
		///</summary>
		public void Set_SuppressZeroInches(bool bVal) 
		{
			this._i.SuppressZeroInches = bVal;
		}

		///<summary>
		///
		///</summary>
		public bool ToleranceSuppressZeroFeet => this._i.ToleranceSuppressZeroFeet;

		///<summary>
		///
		///</summary>
		public void Set_ToleranceSuppressZeroFeet(bool bVal) 
		{
			this._i.ToleranceSuppressZeroFeet = bVal;
		}

		///<summary>
		///
		///</summary>
		public bool ToleranceSuppressZeroInches => this._i.ToleranceSuppressZeroInches;

		///<summary>
		///
		///</summary>
		public void Set_ToleranceSuppressZeroInches(bool bVal) 
		{
			this._i.ToleranceSuppressZeroInches = bVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DimensionLineWeight => this._i.DimensionLineWeight;

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
		public dynamic Arrowhead1Type => this._i.Arrowhead1Type;

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
		public dynamic Arrowhead2Type => this._i.Arrowhead2Type;

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
		public object ArcPoint => this._i.ArcPoint;

		///<summary>
		///
		///</summary>
		public void Set_ArcPoint(object pVal) 
		{
			this._i.ArcPoint = pVal;
		}

		///<summary>
		///
		///</summary>
		public object ExtLine1Point => this._i.ExtLine1Point;

		///<summary>
		///
		///</summary>
		public void Set_ExtLine1Point(object pVal) 
		{
			this._i.ExtLine1Point = pVal;
		}

		///<summary>
		///
		///</summary>
		public object ExtLine2Point => this._i.ExtLine2Point;

		///<summary>
		///
		///</summary>
		public void Set_ExtLine2Point(object pVal) 
		{
			this._i.ExtLine2Point = pVal;
		}

		///<summary>
		///
		///</summary>
		public object CenterPoint => this._i.CenterPoint;

		///<summary>
		///
		///</summary>
		public void Set_CenterPoint(object pVal) 
		{
			this._i.CenterPoint = pVal;
		}

		///<summary>
		///
		///</summary>
		public object Leader1Point => this._i.Leader1Point;

		///<summary>
		///
		///</summary>
		public void Set_Leader1Point(object pVal) 
		{
			this._i.Leader1Point = pVal;
		}

		///<summary>
		///
		///</summary>
		public object Leader2Point => this._i.Leader2Point;

		///<summary>
		///
		///</summary>
		public void Set_Leader2Point(object pVal) 
		{
			this._i.Leader2Point = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool IsPartial => this._i.IsPartial;

		///<summary>
		///
		///</summary>
		public void Set_IsPartial(bool pVal) 
		{
			this._i.IsPartial = pVal;
		}

		///<summary>
		///
		///</summary>
		public double ArcStartParam => this._i.ArcStartParam;

		///<summary>
		///
		///</summary>
		public void Set_ArcStartParam(double pVal) 
		{
			this._i.ArcStartParam = pVal;
		}

		///<summary>
		///
		///</summary>
		public double ArcEndParam => this._i.ArcEndParam;

		///<summary>
		///
		///</summary>
		public void Set_ArcEndParam(double pVal) 
		{
			this._i.ArcEndParam = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool HasLeader => this._i.HasLeader;

		///<summary>
		///
		///</summary>
		public void Set_HasLeader(bool pVal) 
		{
			this._i.HasLeader = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic SymbolPosition => this._i.SymbolPosition;

		///<summary>
		///
		///</summary>
		public void Set_SymbolPosition(Autodesk.AutoCAD.Interop.Common.AcDimArcLengthSymbol Position) 
		{
			this._i.SymbolPosition = Position;
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
		public string SubUnitsSuffix => this._i.SubUnitsSuffix;

		///<summary>
		///
		///</summary>
		public void Set_SubUnitsSuffix(string suffix) 
		{
			this._i.SubUnitsSuffix = suffix;
		}

		///<summary>
		///
		///</summary>
		public double SubUnitsFactor => this._i.SubUnitsFactor;

		///<summary>
		///
		///</summary>
		public void Set_SubUnitsFactor(double factor) 
		{
			this._i.SubUnitsFactor = factor;
		}

		///<summary>
		///
		///</summary>
		public string AltSubUnitsSuffix => this._i.AltSubUnitsSuffix;

		///<summary>
		///
		///</summary>
		public void Set_AltSubUnitsSuffix(string suffix) 
		{
			this._i.AltSubUnitsSuffix = suffix;
		}

		///<summary>
		///
		///</summary>
		public double AltSubUnitsFactor => this._i.AltSubUnitsFactor;

		///<summary>
		///
		///</summary>
		public void Set_AltSubUnitsFactor(double factor) 
		{
			this._i.AltSubUnitsFactor = factor;
		}
	}
}
