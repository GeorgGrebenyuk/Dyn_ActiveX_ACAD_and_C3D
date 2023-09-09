namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyObservation 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyObservation _i;
		internal AeccSurveyObservation(object AeccSurveyObservation_object) 
		{
			this._i = AeccSurveyObservation_object as Autodesk.AECC.Interop.Survey.IAeccSurveyObservation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic PointNumber => this._i.PointNumber;

		///<summary>
		///
		///</summary>
		public double Angle => this._i.Angle;

		///<summary>
		///
		///</summary>
		public void Set_Angle(double pdAngle) 
		{
			this._i.Angle = pdAngle;
		}

		///<summary>
		///
		///</summary>
		public dynamic AngleType => this._i.AngleType;

		///<summary>
		///
		///</summary>
		public void Set_AngleType(Autodesk.AECC.Interop.Survey.AeccSurveyAngleType pAngleType) 
		{
			this._i.AngleType = pAngleType;
		}

		///<summary>
		///
		///</summary>
		public double Distance => this._i.Distance;

		///<summary>
		///
		///</summary>
		public void Set_Distance(double pdDistance) 
		{
			this._i.Distance = pdDistance;
		}

		///<summary>
		///
		///</summary>
		public dynamic DistanceType => this._i.DistanceType;

		///<summary>
		///
		///</summary>
		public void Set_DistanceType(Autodesk.AECC.Interop.Survey.AeccSurveyDistanceType pDistanceType) 
		{
			this._i.DistanceType = pDistanceType;
		}

		///<summary>
		///
		///</summary>
		public double Vertical => this._i.Vertical;

		///<summary>
		///
		///</summary>
		public void Set_Vertical(double pdVertical) 
		{
			this._i.Vertical = pdVertical;
		}

		///<summary>
		///
		///</summary>
		public dynamic VerticalType => this._i.VerticalType;

		///<summary>
		///
		///</summary>
		public void Set_VerticalType(Autodesk.AECC.Interop.Survey.AeccSurveyVerticalType pVerticalType) 
		{
			this._i.VerticalType = pVerticalType;
		}

		///<summary>
		///
		///</summary>
		public double TargetHeight => this._i.TargetHeight;

		///<summary>
		///
		///</summary>
		public void Set_TargetHeight(double pdTargetHeight) 
		{
			this._i.TargetHeight = pdTargetHeight;
		}

		///<summary>
		///
		///</summary>
		public dynamic TargetType => this._i.TargetType;

		///<summary>
		///
		///</summary>
		public void Set_TargetType(Autodesk.AECC.Interop.Survey.AeccSurveyTargetType pTargetType) 
		{
			this._i.TargetType = pTargetType;
		}

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void Set_Description(string pbstrDescription) 
		{
			this._i.Description = pbstrDescription;
		}

		///<summary>
		///
		///</summary>
		public double Northing => this._i.Northing;

		///<summary>
		///
		///</summary>
		public double Easting => this._i.Easting;

		///<summary>
		///
		///</summary>
		public double Elevation => this._i.Elevation;

		///<summary>
		///
		///</summary>
		public double Longitude => this._i.Longitude;

		///<summary>
		///
		///</summary>
		public double Latitude => this._i.Latitude;

		///<summary>
		///
		///</summary>
		public string EquipmentName => this._i.EquipmentName;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentName(string pbstrName) 
		{
			this._i.EquipmentName = pbstrName;
		}

		///<summary>
		///
		///</summary>
		public string EquipmentDescription => this._i.EquipmentDescription;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentDescription(string pbstrDescription) 
		{
			this._i.EquipmentDescription = pbstrDescription;
		}

		///<summary>
		///
		///</summary>
		public dynamic EquipmentMeasuringDevice => this._i.EquipmentMeasuringDevice;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentMeasuringDevice(Autodesk.AECC.Interop.Survey.AeccSurveyMeasuringDeviceType pMeasuringDevice) 
		{
			this._i.EquipmentMeasuringDevice = pMeasuringDevice;
		}

		///<summary>
		///
		///</summary>
		public bool EquipmentIsTiltedPrism => this._i.EquipmentIsTiltedPrism;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentIsTiltedPrism(bool pbIsTiltedPrism) 
		{
			this._i.EquipmentIsTiltedPrism = pbIsTiltedPrism;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentPrismOffset => this._i.EquipmentPrismOffset;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentPrismOffset(double pdPrismOffset) 
		{
			this._i.EquipmentPrismOffset = pdPrismOffset;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentPrismConstant => this._i.EquipmentPrismConstant;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentPrismConstant(double pdPrismConstant) 
		{
			this._i.EquipmentPrismConstant = pdPrismConstant;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentEdmOffset => this._i.EquipmentEdmOffset;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentEdmOffset(double pdEdmOffset) 
		{
			this._i.EquipmentEdmOffset = pdEdmOffset;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentEdmMmError => this._i.EquipmentEdmMmError;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentEdmMmError(double pdEdmMmErrpr) 
		{
			this._i.EquipmentEdmMmError = pdEdmMmErrpr;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentEdmPpmError => this._i.EquipmentEdmPpmError;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentEdmPpmError(double pdEdmPpmError) 
		{
			this._i.EquipmentEdmPpmError = pdEdmPpmError;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentHorizontalCollimation => this._i.EquipmentHorizontalCollimation;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentHorizontalCollimation(double pdHorizontalCollimation) 
		{
			this._i.EquipmentHorizontalCollimation = pdHorizontalCollimation;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentVerticalCollimation => this._i.EquipmentVerticalCollimation;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentVerticalCollimation(double pdVerticalCollimation) 
		{
			this._i.EquipmentVerticalCollimation = pdVerticalCollimation;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentCarrierWaveConstant => this._i.EquipmentCarrierWaveConstant;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentCarrierWaveConstant(double pdCarrierWaveConstant) 
		{
			this._i.EquipmentCarrierWaveConstant = pdCarrierWaveConstant;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentFrequencyRefractiveIndex => this._i.EquipmentFrequencyRefractiveIndex;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentFrequencyRefractiveIndex(double pdFrequencyRefractiveIndex) 
		{
			this._i.EquipmentFrequencyRefractiveIndex = pdFrequencyRefractiveIndex;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentCenterStandard => this._i.EquipmentCenterStandard;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentCenterStandard(double pdCenterStandard) 
		{
			this._i.EquipmentCenterStandard = pdCenterStandard;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentTargetStandard => this._i.EquipmentTargetStandard;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentTargetStandard(double pdTargetStandard) 
		{
			this._i.EquipmentTargetStandard = pdTargetStandard;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentPointingStandard => this._i.EquipmentPointingStandard;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentPointingStandard(double pdPointingStandard) 
		{
			this._i.EquipmentPointingStandard = pdPointingStandard;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentCircleStandard => this._i.EquipmentCircleStandard;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentCircleStandard(double pdCircleStandard) 
		{
			this._i.EquipmentCircleStandard = pdCircleStandard;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentPrismStandard => this._i.EquipmentPrismStandard;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentPrismStandard(double pdPrismStandard) 
		{
			this._i.EquipmentPrismStandard = pdPrismStandard;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentTheodoliteStandard => this._i.EquipmentTheodoliteStandard;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentTheodoliteStandard(double pdTheodoliteStandard) 
		{
			this._i.EquipmentTheodoliteStandard = pdTheodoliteStandard;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentVerticalCircleStandard => this._i.EquipmentVerticalCircleStandard;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentVerticalCircleStandard(double pdVerticalCircleStandard) 
		{
			this._i.EquipmentVerticalCircleStandard = pdVerticalCircleStandard;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentCoordinateStandard => this._i.EquipmentCoordinateStandard;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentCoordinateStandard(double pdCoordinateStandard) 
		{
			this._i.EquipmentCoordinateStandard = pdCoordinateStandard;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentAzimuthStandard => this._i.EquipmentAzimuthStandard;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentAzimuthStandard(double pdAzimuthStandard) 
		{
			this._i.EquipmentAzimuthStandard = pdAzimuthStandard;
		}

		///<summary>
		///
		///</summary>
		public double EquipmentElevationStandard => this._i.EquipmentElevationStandard;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentElevationStandard(double pdElevationStandard) 
		{
			this._i.EquipmentElevationStandard = pdElevationStandard;
		}

		///<summary>
		///
		///</summary>
		public dynamic EquipmentDistanceUnit => this._i.EquipmentDistanceUnit;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentDistanceUnit(Autodesk.AECC.Interop.Survey.AeccSurveyDistanceUnit pDistanceUnit) 
		{
			this._i.EquipmentDistanceUnit = pDistanceUnit;
		}

		///<summary>
		///
		///</summary>
		public dynamic EquipmentAngleUnit => this._i.EquipmentAngleUnit;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentAngleUnit(Autodesk.AECC.Interop.Survey.AeccSurveyAngleUnit pAngleUnit) 
		{
			this._i.EquipmentAngleUnit = pAngleUnit;
		}

		///<summary>
		///
		///</summary>
		public dynamic EquipmentAngleType => this._i.EquipmentAngleType;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentAngleType(Autodesk.AECC.Interop.Survey.AeccSurveyEquipmentAngleType pAngleType) 
		{
			this._i.EquipmentAngleType = pAngleType;
		}

		///<summary>
		///
		///</summary>
		public dynamic EquipmentVerticalAngleType => this._i.EquipmentVerticalAngleType;

		///<summary>
		///
		///</summary>
		public void Set_EquipmentVerticalAngleType(Autodesk.AECC.Interop.Survey.AeccSurveyEquipmentVerticalAngleType pVerticalAngleType) 
		{
			this._i.EquipmentVerticalAngleType = pVerticalAngleType;
		}

		///<summary>
		///
		///</summary>
		public double CorrectionTemperature => this._i.CorrectionTemperature;

		///<summary>
		///
		///</summary>
		public void Set_CorrectionTemperature(double pdCorrectionTemperature) 
		{
			this._i.CorrectionTemperature = pdCorrectionTemperature;
		}

		///<summary>
		///
		///</summary>
		public double CorrectionPressure => this._i.CorrectionPressure;

		///<summary>
		///
		///</summary>
		public void Set_CorrectionPressure(double pdCorrectionPressure) 
		{
			this._i.CorrectionPressure = pdCorrectionPressure;
		}

		///<summary>
		///
		///</summary>
		public double ScaleFactor => this._i.ScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ScaleFactor(double pdScaleFactor) 
		{
			this._i.ScaleFactor = pdScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public dynamic Setup => this._i.Setup;

		///<summary>
		///
		///</summary>
		public dynamic Network => this._i.Network;

		///<summary>
		///
		///</summary>
		public dynamic Project => this._i.Project;
	}
}
