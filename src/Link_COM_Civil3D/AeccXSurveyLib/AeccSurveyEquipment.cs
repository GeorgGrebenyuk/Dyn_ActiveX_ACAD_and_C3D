namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyEquipment 
	{
		public Autodesk.AECC.Interop.Survey.IAeccSurveyEquipment _i;
		internal AeccSurveyEquipment(object AeccSurveyEquipment_object) 
		{
			this._i = AeccSurveyEquipment_object as Autodesk.AECC.Interop.Survey.IAeccSurveyEquipment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string pbstrName) 
		{
			this._i.Name = pbstrName;
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
		public dynamic MeasuringDevice => this._i.MeasuringDevice;

		///<summary>
		///
		///</summary>
		public void Set_MeasuringDevice(Autodesk.AECC.Interop.Survey.AeccSurveyMeasuringDeviceType pMeasuringDevice) 
		{
			this._i.MeasuringDevice = pMeasuringDevice;
		}

		///<summary>
		///
		///</summary>
		public bool IsTiltedPrism => this._i.IsTiltedPrism;

		///<summary>
		///
		///</summary>
		public void Set_IsTiltedPrism(bool pbIsTiltedPrism) 
		{
			this._i.IsTiltedPrism = pbIsTiltedPrism;
		}

		///<summary>
		///
		///</summary>
		public double PrismOffset => this._i.PrismOffset;

		///<summary>
		///
		///</summary>
		public void Set_PrismOffset(double pdPrismOffset) 
		{
			this._i.PrismOffset = pdPrismOffset;
		}

		///<summary>
		///
		///</summary>
		public double PrismConstant => this._i.PrismConstant;

		///<summary>
		///
		///</summary>
		public void Set_PrismConstant(double pdPrismConstant) 
		{
			this._i.PrismConstant = pdPrismConstant;
		}

		///<summary>
		///
		///</summary>
		public double EdmOffset => this._i.EdmOffset;

		///<summary>
		///
		///</summary>
		public void Set_EdmOffset(double pdEdmOffset) 
		{
			this._i.EdmOffset = pdEdmOffset;
		}

		///<summary>
		///
		///</summary>
		public double EdmMmError => this._i.EdmMmError;

		///<summary>
		///
		///</summary>
		public void Set_EdmMmError(double pdEdmMmErrpr) 
		{
			this._i.EdmMmError = pdEdmMmErrpr;
		}

		///<summary>
		///
		///</summary>
		public double EdmPpmError => this._i.EdmPpmError;

		///<summary>
		///
		///</summary>
		public void Set_EdmPpmError(double pdEdmPpmError) 
		{
			this._i.EdmPpmError = pdEdmPpmError;
		}

		///<summary>
		///
		///</summary>
		public double HorizontalCollimation => this._i.HorizontalCollimation;

		///<summary>
		///
		///</summary>
		public void Set_HorizontalCollimation(double pdHorizontalCollimation) 
		{
			this._i.HorizontalCollimation = pdHorizontalCollimation;
		}

		///<summary>
		///
		///</summary>
		public double VerticalCollimation => this._i.VerticalCollimation;

		///<summary>
		///
		///</summary>
		public void Set_VerticalCollimation(double pdVerticalCollimation) 
		{
			this._i.VerticalCollimation = pdVerticalCollimation;
		}

		///<summary>
		///
		///</summary>
		public double CarrierWaveConstant => this._i.CarrierWaveConstant;

		///<summary>
		///
		///</summary>
		public void Set_CarrierWaveConstant(double pdCarrierWaveConstant) 
		{
			this._i.CarrierWaveConstant = pdCarrierWaveConstant;
		}

		///<summary>
		///
		///</summary>
		public double FrequencyRefractiveIndex => this._i.FrequencyRefractiveIndex;

		///<summary>
		///
		///</summary>
		public void Set_FrequencyRefractiveIndex(double pdFrequencyRefractiveIndex) 
		{
			this._i.FrequencyRefractiveIndex = pdFrequencyRefractiveIndex;
		}

		///<summary>
		///
		///</summary>
		public double CenterStandard => this._i.CenterStandard;

		///<summary>
		///
		///</summary>
		public void Set_CenterStandard(double pdCenterStandard) 
		{
			this._i.CenterStandard = pdCenterStandard;
		}

		///<summary>
		///
		///</summary>
		public double TargetStandard => this._i.TargetStandard;

		///<summary>
		///
		///</summary>
		public void Set_TargetStandard(double pdTargetStandard) 
		{
			this._i.TargetStandard = pdTargetStandard;
		}

		///<summary>
		///
		///</summary>
		public double PointingStandard => this._i.PointingStandard;

		///<summary>
		///
		///</summary>
		public void Set_PointingStandard(double pdPointingStandard) 
		{
			this._i.PointingStandard = pdPointingStandard;
		}

		///<summary>
		///
		///</summary>
		public double CircleStandard => this._i.CircleStandard;

		///<summary>
		///
		///</summary>
		public void Set_CircleStandard(double pdCircleStandard) 
		{
			this._i.CircleStandard = pdCircleStandard;
		}

		///<summary>
		///
		///</summary>
		public double PrismStandard => this._i.PrismStandard;

		///<summary>
		///
		///</summary>
		public void Set_PrismStandard(double pdPrismStandard) 
		{
			this._i.PrismStandard = pdPrismStandard;
		}

		///<summary>
		///
		///</summary>
		public double TheodoliteStandard => this._i.TheodoliteStandard;

		///<summary>
		///
		///</summary>
		public void Set_TheodoliteStandard(double pdTheodoliteStandard) 
		{
			this._i.TheodoliteStandard = pdTheodoliteStandard;
		}

		///<summary>
		///
		///</summary>
		public double VerticalCircleStandard => this._i.VerticalCircleStandard;

		///<summary>
		///
		///</summary>
		public void Set_VerticalCircleStandard(double pdVerticalCircleStandard) 
		{
			this._i.VerticalCircleStandard = pdVerticalCircleStandard;
		}

		///<summary>
		///
		///</summary>
		public double CoordinateStandard => this._i.CoordinateStandard;

		///<summary>
		///
		///</summary>
		public void Set_CoordinateStandard(double pdCoordinateStandard) 
		{
			this._i.CoordinateStandard = pdCoordinateStandard;
		}

		///<summary>
		///
		///</summary>
		public double AzimuthStandard => this._i.AzimuthStandard;

		///<summary>
		///
		///</summary>
		public void Set_AzimuthStandard(double pdAzimuthStandard) 
		{
			this._i.AzimuthStandard = pdAzimuthStandard;
		}

		///<summary>
		///
		///</summary>
		public double ElevationStandard => this._i.ElevationStandard;

		///<summary>
		///
		///</summary>
		public void Set_ElevationStandard(double pdElevationStandard) 
		{
			this._i.ElevationStandard = pdElevationStandard;
		}

		///<summary>
		///
		///</summary>
		public dynamic DistanceUnit => this._i.DistanceUnit;

		///<summary>
		///
		///</summary>
		public void Set_DistanceUnit(Autodesk.AECC.Interop.Survey.AeccSurveyDistanceUnit pDistanceUnit) 
		{
			this._i.DistanceUnit = pDistanceUnit;
		}

		///<summary>
		///
		///</summary>
		public dynamic AngleUnit => this._i.AngleUnit;

		///<summary>
		///
		///</summary>
		public void Set_AngleUnit(Autodesk.AECC.Interop.Survey.AeccSurveyAngleUnit pAngleUnit) 
		{
			this._i.AngleUnit = pAngleUnit;
		}

		///<summary>
		///
		///</summary>
		public dynamic AngleType => this._i.AngleType;

		///<summary>
		///
		///</summary>
		public void Set_AngleType(Autodesk.AECC.Interop.Survey.AeccSurveyEquipmentAngleType pAngleType) 
		{
			this._i.AngleType = pAngleType;
		}

		///<summary>
		///
		///</summary>
		public dynamic VerticalAngleType => this._i.VerticalAngleType;

		///<summary>
		///
		///</summary>
		public void Set_VerticalAngleType(Autodesk.AECC.Interop.Survey.AeccSurveyEquipmentVerticalAngleType pVerticalAngleType) 
		{
			this._i.VerticalAngleType = pVerticalAngleType;
		}

		///<summary>
		///
		///</summary>
		public void CopyFrom(dynamic piEquipment) 
		{
			this._i.CopyFrom(piEquipment);
		}
	}
}
