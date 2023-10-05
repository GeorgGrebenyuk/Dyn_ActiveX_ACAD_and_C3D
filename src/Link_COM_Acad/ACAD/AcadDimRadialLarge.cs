using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

    ///<summary>
    /// A dimension measuring a large radius, also known as a jogged radius dimension
    ///</summary>
    public class AcadDimRadialLarge 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadDimRadialLarge _i;
		internal AcadDimRadialLarge(object AcadDimRadialLarge_object) 
		{
			this._i = AcadDimRadialLarge_object as Autodesk.AutoCAD.Interop.Common.AcadDimRadialLarge;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadDimRadialLarge(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadDimRadialLarge;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        /// <summary>
		/// Creates a jogged radial dimension for an arc, circle, or polyline arc segment
		/// </summary>
		/// <param name="AcadBlock"></param>
		/// <param name="Center">The 3D WCS coordinates specifying the center of the arc, circle, or polyline arc segment</param>
		/// <param name="ChordPoint">The 3D WCS coordinates specifying the chord point for the arc</param>
		/// <param name="OverrideCenter">The 3D WCS coordinates specifying the override center location or pick point</param>
		/// <param name="JogPoint">The 3D WCS coordinates specifying the jog location or pick point</param>
		/// <param name="JogAngle">The value for the jog angle</param>
        public AcadDimRadialLarge(AcadBlock AcadBlock, Point Center, Point ChordPoint, Point OverrideCenter, Point JogPoint, double JogAngle)
        {
            this._i =  AcadBlock._i.AddDimRadialLarge(Technical.PointByDynPoint(Center),
                Technical.PointByDynPoint(ChordPoint), Technical.PointByDynPoint(OverrideCenter),
                Technical.PointByDynPoint(JogPoint), JogAngle);
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
		public object AltUnitsPrecision => this._i.AltUnitsPrecision;

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
		public double AltUnitsScale => this._i.AltUnitsScale;

		///<summary>
		///
		///</summary>
		public void Set_AltUnitsScale(double scale) 
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
		public object AltTolerancePrecision => this._i.AltTolerancePrecision;

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
		public object AltUnitsFormat => this._i.AltUnitsFormat;

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
		public object CenterType => this._i.CenterType;

		///<summary>
		///
		///</summary>
		public void Set_CenterType(Autodesk.AutoCAD.Interop.Common.AcDimCenterType Type) 
		{
			this._i.CenterType = Type;
		}

		///<summary>
		///
		///</summary>
		public double CenterMarkSize => this._i.CenterMarkSize;

		///<summary>
		///
		///</summary>
		public void Set_CenterMarkSize(double Type) 
		{
			this._i.CenterMarkSize = Type;
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
		public object PrimaryUnitsPrecision => this._i.PrimaryUnitsPrecision;

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
		public object FractionFormat => this._i.FractionFormat;

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
		public double LinearScaleFactor => this._i.LinearScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_LinearScaleFactor(double Type) 
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
		public bool DimLineSuppress => this._i.DimLineSuppress;

		///<summary>
		///
		///</summary>
		public void Set_DimLineSuppress(bool bSuppress) 
		{
			this._i.DimLineSuppress = bSuppress;
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
		public dynamic ArrowheadType => this._i.ArrowheadType;

		///<summary>
		///
		///</summary>
		public void Set_ArrowheadType(Autodesk.AutoCAD.Interop.Common.AcDimArrowheadType Type) 
		{
			this._i.ArrowheadType = Type;
		}

		///<summary>
		///
		///</summary>
		public double Measurement => this._i.Measurement;

		///<summary>
		///
		///</summary>
		public string ArrowheadBlock => this._i.ArrowheadBlock;

		///<summary>
		///
		///</summary>
		public void Set_ArrowheadBlock(string BlockName) 
		{
			this._i.ArrowheadBlock = BlockName;
		}

		///<summary>
		///
		///</summary>
		public object OverrideCenter => this._i.OverrideCenter;

		///<summary>
		///
		///</summary>
		public void Set_OverrideCenter(object overrideCenterPos) 
		{
			this._i.OverrideCenter = overrideCenterPos;
		}

		///<summary>
		///
		///</summary>
		public object JogLocation => this._i.JogLocation;

		///<summary>
		///
		///</summary>
		public void Set_JogLocation(object jogPos) 
		{
			this._i.JogLocation = jogPos;
		}

		///<summary>
		///
		///</summary>
		public dynamic JogAngle => this._i.JogAngle;

		///<summary>
		///
		///</summary>
		public void Set_JogAngle(dynamic JogAngle) 
		{
			this._i.JogAngle = JogAngle;
		}

		///<summary>
		///
		///</summary>
		public object Center => this._i.Center;

		///<summary>
		///
		///</summary>
		public void Set_Center(object pVar) 
		{
			this._i.Center = pVar;
		}

		///<summary>
		///
		///</summary>
		public object ChordPoint => this._i.ChordPoint;

		///<summary>
		///
		///</summary>
		public void Set_ChordPoint(object pVal) 
		{
			this._i.ChordPoint = pVal;
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
	}
}
