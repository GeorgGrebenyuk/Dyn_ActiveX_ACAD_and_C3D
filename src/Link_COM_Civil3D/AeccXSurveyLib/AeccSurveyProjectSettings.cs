namespace DynAeccXSurveyLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurveyProjectSettings 
	{
		public AeccXSurveyLib.IAeccSurveyProjectSettings _i;
		internal AeccSurveyProjectSettings(object AeccSurveyProjectSettings_object) 
		{
			this._i = AeccSurveyProjectSettings_object as AeccXSurveyLib.IAeccSurveyProjectSettings;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Zone => this._i.Zone;

		///<summary>
		///
		///</summary>
		public void Set_Zone(string pVal) 
		{
			this._i.Zone = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DistanceUnit => this._i.DistanceUnit;

		///<summary>
		///
		///</summary>
		public void Set_DistanceUnit(AeccXSurveyLib.AeccSurveyDistanceUnit pVal) 
		{
			this._i.DistanceUnit = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic AngleUnit => this._i.AngleUnit;

		///<summary>
		///
		///</summary>
		public void Set_AngleUnit(AeccXSurveyLib.AeccSurveyAngleUnit pVal) 
		{
			this._i.AngleUnit = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DirectionUnit => this._i.DirectionUnit;

		///<summary>
		///
		///</summary>
		public void Set_DirectionUnit(AeccXSurveyLib.AeccSurveyDirectionUnit pVal) 
		{
			this._i.DirectionUnit = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic TemperatureUnit => this._i.TemperatureUnit;

		///<summary>
		///
		///</summary>
		public void Set_TemperatureUnit(AeccXSurveyLib.AeccSurveyTemperatureUnit pVal) 
		{
			this._i.TemperatureUnit = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic PressureUnit => this._i.PressureUnit;

		///<summary>
		///
		///</summary>
		public void Set_PressureUnit(AeccXSurveyLib.AeccSurveyPressureUnit pVal) 
		{
			this._i.PressureUnit = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic AnglePrecision => this._i.AnglePrecision;

		///<summary>
		///
		///</summary>
		public void Set_AnglePrecision(dynamic pVal) 
		{
			this._i.AnglePrecision = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DistancePrecision => this._i.DistancePrecision;

		///<summary>
		///
		///</summary>
		public void Set_DistancePrecision(dynamic pVal) 
		{
			this._i.DistancePrecision = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ElevationPrecision => this._i.ElevationPrecision;

		///<summary>
		///
		///</summary>
		public void Set_ElevationPrecision(dynamic pVal) 
		{
			this._i.ElevationPrecision = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic CoordinatePrecision => this._i.CoordinatePrecision;

		///<summary>
		///
		///</summary>
		public void Set_CoordinatePrecision(dynamic pVal) 
		{
			this._i.CoordinatePrecision = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic LatLongPrecision => this._i.LatLongPrecision;

		///<summary>
		///
		///</summary>
		public void Set_LatLongPrecision(dynamic pVal) 
		{
			this._i.LatLongPrecision = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic AngleType => this._i.AngleType;

		///<summary>
		///
		///</summary>
		public void Set_AngleType(AeccXSurveyLib.AeccSurveyAngleType pVal) 
		{
			this._i.AngleType = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DistanceType => this._i.DistanceType;

		///<summary>
		///
		///</summary>
		public void Set_DistanceType(AeccXSurveyLib.AeccSurveyDistanceType pVal) 
		{
			this._i.DistanceType = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic VerticalType => this._i.VerticalType;

		///<summary>
		///
		///</summary>
		public void Set_VerticalType(AeccXSurveyLib.AeccSurveyVerticalType pVal) 
		{
			this._i.VerticalType = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic TargetType => this._i.TargetType;

		///<summary>
		///
		///</summary>
		public void Set_TargetType(AeccXSurveyLib.AeccSurveyTargetType pVal) 
		{
			this._i.TargetType = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool CurvatureAndRefractionCorrection => this._i.CurvatureAndRefractionCorrection;

		///<summary>
		///
		///</summary>
		public void Set_CurvatureAndRefractionCorrection(bool pVal) 
		{
			this._i.CurvatureAndRefractionCorrection = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool SeaLevelCorrection => this._i.SeaLevelCorrection;

		///<summary>
		///
		///</summary>
		public void Set_SeaLevelCorrection(bool pVal) 
		{
			this._i.SeaLevelCorrection = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool AtmosphericConditionsCorrection => this._i.AtmosphericConditionsCorrection;

		///<summary>
		///
		///</summary>
		public void Set_AtmosphericConditionsCorrection(bool pVal) 
		{
			this._i.AtmosphericConditionsCorrection = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool HorizontalCollimationCorrection => this._i.HorizontalCollimationCorrection;

		///<summary>
		///
		///</summary>
		public void Set_HorizontalCollimationCorrection(bool pVal) 
		{
			this._i.HorizontalCollimationCorrection = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool VerticalCollimationCorrection => this._i.VerticalCollimationCorrection;

		///<summary>
		///
		///</summary>
		public void Set_VerticalCollimationCorrection(bool pVal) 
		{
			this._i.VerticalCollimationCorrection = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ScaleFactorCorrection => this._i.ScaleFactorCorrection;

		///<summary>
		///
		///</summary>
		public void Set_ScaleFactorCorrection(bool pVal) 
		{
			this._i.ScaleFactorCorrection = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool EDMPrismEccentricityCorrection => this._i.EDMPrismEccentricityCorrection;

		///<summary>
		///
		///</summary>
		public void Set_EDMPrismEccentricityCorrection(bool pVal) 
		{
			this._i.EDMPrismEccentricityCorrection = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool DoTraverseAnalysis => this._i.DoTraverseAnalysis;

		///<summary>
		///
		///</summary>
		public void Set_DoTraverseAnalysis(bool pVal) 
		{
			this._i.DoTraverseAnalysis = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool DoAngleBalance => this._i.DoAngleBalance;

		///<summary>
		///
		///</summary>
		public void Set_DoAngleBalance(bool pVal) 
		{
			this._i.DoAngleBalance = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic HorizontalAdjustMethod => this._i.HorizontalAdjustMethod;

		///<summary>
		///
		///</summary>
		public void Set_HorizontalAdjustMethod(AeccXSurveyLib.AeccSurveyHorizontalAdjustMethod pVal) 
		{
			this._i.HorizontalAdjustMethod = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic VerticalAdjustMethod => this._i.VerticalAdjustMethod;

		///<summary>
		///
		///</summary>
		public void Set_VerticalAdjustMethod(AeccXSurveyLib.AeccSurveyVerticalAdjustMethod pVal) 
		{
			this._i.VerticalAdjustMethod = pVal;
		}

		///<summary>
		///
		///</summary>
		public double HorizontalClosureLimit => this._i.HorizontalClosureLimit;

		///<summary>
		///
		///</summary>
		public void Set_HorizontalClosureLimit(double pVal) 
		{
			this._i.HorizontalClosureLimit = pVal;
		}

		///<summary>
		///
		///</summary>
		public double VerticalClosureLimit => this._i.VerticalClosureLimit;

		///<summary>
		///
		///</summary>
		public void Set_VerticalClosureLimit(double pVal) 
		{
			this._i.VerticalClosureLimit = pVal;
		}

		///<summary>
		///
		///</summary>
		public double AngleError => this._i.AngleError;

		///<summary>
		///
		///</summary>
		public void Set_AngleError(double pVal) 
		{
			this._i.AngleError = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NetworkAdjustmentType => this._i.NetworkAdjustmentType;

		///<summary>
		///
		///</summary>
		public void Set_NetworkAdjustmentType(AeccXSurveyLib.AeccSurveyNetworkAdjustmentType pVal) 
		{
			this._i.NetworkAdjustmentType = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic MaxNumberOfIterations => this._i.MaxNumberOfIterations;

		///<summary>
		///
		///</summary>
		public void Set_MaxNumberOfIterations(dynamic pVal) 
		{
			this._i.MaxNumberOfIterations = pVal;
		}

		///<summary>
		///
		///</summary>
		public double CoordinateConvergence => this._i.CoordinateConvergence;

		///<summary>
		///
		///</summary>
		public void Set_CoordinateConvergence(double pVal) 
		{
			this._i.CoordinateConvergence = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic ConfidenceInterval => this._i.ConfidenceInterval;

		///<summary>
		///
		///</summary>
		public void Set_ConfidenceInterval(AeccXSurveyLib.AeccSurveyConfidenceInterval pVal) 
		{
			this._i.ConfidenceInterval = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool PerformBlunderDetection => this._i.PerformBlunderDetection;

		///<summary>
		///
		///</summary>
		public void Set_PerformBlunderDetection(bool pVal) 
		{
			this._i.PerformBlunderDetection = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool DittoFeature => this._i.DittoFeature;

		///<summary>
		///
		///</summary>
		public void Set_DittoFeature(bool pVal) 
		{
			this._i.DittoFeature = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool PointCourseEcho => this._i.PointCourseEcho;

		///<summary>
		///
		///</summary>
		public void Set_PointCourseEcho(bool pVal) 
		{
			this._i.PointCourseEcho = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool FigureCourseEcho => this._i.FigureCourseEcho;

		///<summary>
		///
		///</summary>
		public void Set_FigureCourseEcho(bool pVal) 
		{
			this._i.FigureCourseEcho = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool PointCoordinateEcho => this._i.PointCoordinateEcho;

		///<summary>
		///
		///</summary>
		public void Set_PointCoordinateEcho(bool pVal) 
		{
			this._i.PointCoordinateEcho = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool FigureCoordinateEcho => this._i.FigureCoordinateEcho;

		///<summary>
		///
		///</summary>
		public void Set_FigureCoordinateEcho(bool pVal) 
		{
			this._i.FigureCoordinateEcho = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool CommandEcho => this._i.CommandEcho;

		///<summary>
		///
		///</summary>
		public void Set_CommandEcho(bool pVal) 
		{
			this._i.CommandEcho = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseBatchFile => this._i.UseBatchFile;

		///<summary>
		///
		///</summary>
		public void Set_UseBatchFile(bool pVal) 
		{
			this._i.UseBatchFile = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseOutputFile => this._i.UseOutputFile;

		///<summary>
		///
		///</summary>
		public void Set_UseOutputFile(bool pVal) 
		{
			this._i.UseOutputFile = pVal;
		}

		///<summary>
		///
		///</summary>
		public string BatchFileName => this._i.BatchFileName;

		///<summary>
		///
		///</summary>
		public void Set_BatchFileName(string pVal) 
		{
			this._i.BatchFileName = pVal;
		}

		///<summary>
		///
		///</summary>
		public string OutputFileName => this._i.OutputFileName;

		///<summary>
		///
		///</summary>
		public void Set_OutputFileName(string pVal) 
		{
			this._i.OutputFileName = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic OverwriteStatus => this._i.OverwriteStatus;

		///<summary>
		///
		///</summary>
		public void Set_OverwriteStatus(AeccXSurveyLib.AeccSurveyOverwriteStatus pVal) 
		{
			this._i.OverwriteStatus = pVal;
		}

		///<summary>
		///
		///</summary>
		public double DistanceDifference => this._i.DistanceDifference;

		///<summary>
		///
		///</summary>
		public void Set_DistanceDifference(double pVal) 
		{
			this._i.DistanceDifference = pVal;
		}

		///<summary>
		///
		///</summary>
		public double AngularDifference => this._i.AngularDifference;

		///<summary>
		///
		///</summary>
		public void Set_AngularDifference(double pVal) 
		{
			this._i.AngularDifference = pVal;
		}

		///<summary>
		///
		///</summary>
		public double ElevationDifference => this._i.ElevationDifference;

		///<summary>
		///
		///</summary>
		public void Set_ElevationDifference(double pVal) 
		{
			this._i.ElevationDifference = pVal;
		}

		///<summary>
		///
		///</summary>
		public double CoordinateDifference => this._i.CoordinateDifference;

		///<summary>
		///
		///</summary>
		public void Set_CoordinateDifference(double pVal) 
		{
			this._i.CoordinateDifference = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseDistanceDifference => this._i.UseDistanceDifference;

		///<summary>
		///
		///</summary>
		public void Set_UseDistanceDifference(bool pVal) 
		{
			this._i.UseDistanceDifference = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseAngularDifference => this._i.UseAngularDifference;

		///<summary>
		///
		///</summary>
		public void Set_UseAngularDifference(bool pVal) 
		{
			this._i.UseAngularDifference = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseElevationDifference => this._i.UseElevationDifference;

		///<summary>
		///
		///</summary>
		public void Set_UseElevationDifference(bool pVal) 
		{
			this._i.UseElevationDifference = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseCoordinateDifference => this._i.UseCoordinateDifference;

		///<summary>
		///
		///</summary>
		public void Set_UseCoordinateDifference(bool pVal) 
		{
			this._i.UseCoordinateDifference = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool AutoPointNumbering => this._i.AutoPointNumbering;

		///<summary>
		///
		///</summary>
		public void Set_AutoPointNumbering(bool pVal) 
		{
			this._i.AutoPointNumbering = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic AutoPointNumber => this._i.AutoPointNumber;

		///<summary>
		///
		///</summary>
		public void Set_AutoPointNumber(dynamic pVal) 
		{
			this._i.AutoPointNumber = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UpdateSurveyDatabase => this._i.UpdateSurveyDatabase;

		///<summary>
		///
		///</summary>
		public void Set_UpdateSurveyDatabase(bool pVal) 
		{
			this._i.UpdateSurveyDatabase = pVal;
		}

		///<summary>
		///
		///</summary>
		public double RefractionCoefficient => this._i.RefractionCoefficient;

		///<summary>
		///
		///</summary>
		public void Set_RefractionCoefficient(double pVal) 
		{
			this._i.RefractionCoefficient = pVal;
		}

		///<summary>
		///
		///</summary>
		public double ConvertUiToMetric(double dUI) 
		{
			return this._i.ConvertUiToMetric(dUI);
		}

		///<summary>
		///
		///</summary>
		public double ConvertMetricToUi(double dMetric) 
		{
			return this._i.ConvertMetricToUi(dMetric);
		}

		///<summary>
		///
		///</summary>
		public void ConvertEastingNorthingToLongitudeLatitude(double dEasting,double dNorthing,out double pdLongitude,out double pdLatitude) 
		{
			this._i.ConvertEastingNorthingToLongitudeLatitude(dEasting,dNorthing,out pdLongitude,out pdLatitude);
		}

		///<summary>
		///
		///</summary>
		public void ConvertLongitudeLatitudeToEastingNorthing(double dLongitude,double dLatitude,out double pdEasting,out double pdNorthing) 
		{
			this._i.ConvertLongitudeLatitudeToEastingNorthing(dLongitude,dLatitude,out pdEasting,out pdNorthing);
		}
	}
}
