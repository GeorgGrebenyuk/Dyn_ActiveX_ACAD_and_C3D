using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadDimOrdinate 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadDimOrdinate _i;
		internal AcadDimOrdinate(object AcadDimOrdinate_object) 
		{
			this._i = AcadDimOrdinate_object as Autodesk.AutoCAD.Interop.Common.AcadDimOrdinate;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadDimOrdinate(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadDimOrdinate;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }

        ///<summary>
        ///
        ///</summary>
        public AcadDimOrdinate (AcadBlock AcadBlock, Point DefinitionPoint, Point LeaderEndPoint, int UseXAxis)
        {
            this._i =  AcadBlock._i.AddDimOrdinate(Technical.PointByDynPoint(DefinitionPoint),
                Technical.PointByDynPoint(LeaderEndPoint), UseXAxis);
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
		public object UnitsFormat => this._i.UnitsFormat;

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
		public double Measurement => this._i.Measurement;

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
