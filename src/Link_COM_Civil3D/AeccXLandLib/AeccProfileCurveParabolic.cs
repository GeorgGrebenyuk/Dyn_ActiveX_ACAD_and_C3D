namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileCurveParabolic 
	{
		public AeccXLandLib.IAeccProfileCurveParabolic _i;
		internal AeccProfileCurveParabolic(object AeccProfileCurveParabolic_object) 
		{
			this._i = AeccProfileCurveParabolic_object as AeccXLandLib.IAeccProfileCurveParabolic;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CurveType => this._i.CurveType;

		///<summary>
		///
		///</summary>
		public double GetPassingSightDistance(double dEyeHeight,double dObjectHeight) 
		{
			return this._i.GetPassingSightDistance(dEyeHeight,dObjectHeight);
		}

		///<summary>
		///
		///</summary>
		public void SetPassingSightDistance(double dEyeHeight,double dObjectHeight,double dDistance) 
		{
			this._i.SetPassingSightDistance(dEyeHeight,dObjectHeight,dDistance);
		}

		///<summary>
		///
		///</summary>
		public double GetStopingSightDistance(double dEyeHeight,double dObjectHeight) 
		{
			return this._i.GetStopingSightDistance(dEyeHeight,dObjectHeight);
		}

		///<summary>
		///
		///</summary>
		public void SetStopingSightDistance(double dEyeHeight,double dObjectHeight,double dDistance) 
		{
			this._i.SetStopingSightDistance(dEyeHeight,dObjectHeight,dDistance);
		}

		///<summary>
		///
		///</summary>
		public double GetHeadlightSightDistance(double dMaxAngle,double dHeadlightHeight) 
		{
			return this._i.GetHeadlightSightDistance(dMaxAngle,dHeadlightHeight);
		}

		///<summary>
		///
		///</summary>
		public void SetHeadlightSightDistance(double dMaxAngle,double dHeadlightHeight,double dDistance) 
		{
			this._i.SetHeadlightSightDistance(dMaxAngle,dHeadlightHeight,dDistance);
		}

		///<summary>
		///
		///</summary>
		public double PVIStation => this._i.PVIStation;

		///<summary>
		///
		///</summary>
		public double PVIElevation => this._i.PVIElevation;

		///<summary>
		///
		///</summary>
		public double GradeIn => this._i.GradeIn;

		///<summary>
		///
		///</summary>
		public double GradeOut => this._i.GradeOut;

		///<summary>
		///
		///</summary>
		public double GradeChange => this._i.GradeChange;

		///<summary>
		///
		///</summary>
		public double K => this._i.K;

		///<summary>
		///
		///</summary>
		public void Set_K(double pdK) 
		{
			this._i.K = pdK;
		}

		///<summary>
		///
		///</summary>
		public double Radius => this._i.Radius;

		///<summary>
		///
		///</summary>
		public void Set_Radius(double pdRadius) 
		{
			this._i.Radius = pdRadius;
		}

		///<summary>
		///
		///</summary>
		public double HighLowPointStation => this._i.HighLowPointStation;

		///<summary>
		///
		///</summary>
		public double HighLowPointElevation => this._i.HighLowPointElevation;

		///<summary>
		///
		///</summary>
		public double TangentOffsetAtPVI => this._i.TangentOffsetAtPVI;

		///<summary>
		///
		///</summary>
		public double M => this._i.M;

		///<summary>
		///
		///</summary>
		public double ThroughPoint1Station => this._i.ThroughPoint1Station;

		///<summary>
		///
		///</summary>
		public void Set_ThroughPoint1Station(double pdStation) 
		{
			this._i.ThroughPoint1Station = pdStation;
		}

		///<summary>
		///
		///</summary>
		public double ThroughPoint1Elevation => this._i.ThroughPoint1Elevation;

		///<summary>
		///
		///</summary>
		public void Set_ThroughPoint1Elevation(double pdElevation) 
		{
			this._i.ThroughPoint1Elevation = pdElevation;
		}

		///<summary>
		///
		///</summary>
		public double ThroughPoint2Station => this._i.ThroughPoint2Station;

		///<summary>
		///
		///</summary>
		public void Set_ThroughPoint2Station(double pdStation) 
		{
			this._i.ThroughPoint2Station = pdStation;
		}

		///<summary>
		///
		///</summary>
		public double ThroughPoint2Elevation => this._i.ThroughPoint2Elevation;

		///<summary>
		///
		///</summary>
		public void Set_ThroughPoint2Elevation(double pdElevation) 
		{
			this._i.ThroughPoint2Elevation = pdElevation;
		}

		///<summary>
		///
		///</summary>
		public double ThroughPoint3Station => this._i.ThroughPoint3Station;

		///<summary>
		///
		///</summary>
		public void Set_ThroughPoint3Station(double pdStation) 
		{
			this._i.ThroughPoint3Station = pdStation;
		}

		///<summary>
		///
		///</summary>
		public double ThroughPoint3Elevation => this._i.ThroughPoint3Elevation;

		///<summary>
		///
		///</summary>
		public void Set_ThroughPoint3Elevation(double pdElevation) 
		{
			this._i.ThroughPoint3Elevation = pdElevation;
		}

		///<summary>
		///
		///</summary>
		public double GradeAtThroughPoint1 => this._i.GradeAtThroughPoint1;

		///<summary>
		///
		///</summary>
		public void Set_GradeAtThroughPoint1(double pdGrade) 
		{
			this._i.GradeAtThroughPoint1 = pdGrade;
		}

		///<summary>
		///
		///</summary>
		public double GradeAtThroughPoint2 => this._i.GradeAtThroughPoint2;

		///<summary>
		///
		///</summary>
		public void Set_GradeAtThroughPoint2(double pdGrade) 
		{
			this._i.GradeAtThroughPoint2 = pdGrade;
		}
	}
}
