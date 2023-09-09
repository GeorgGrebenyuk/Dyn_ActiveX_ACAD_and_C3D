namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAbbreviationProfile 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAbbreviationProfile _i;
		internal AeccSettingsAbbreviationProfile(object AeccSettingsAbbreviationProfile_object) 
		{
			this._i = AeccSettingsAbbreviationProfile_object as Autodesk.AECC.Interop.Land.IAeccSettingsAbbreviationProfile;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_PointOfVerticalIntersection(string pVal) 
		{
			this._i.PointOfVerticalIntersection = pVal;
		}

		///<summary>
		///
		///</summary>
		public string PointOfVerticalIntersection => this._i.PointOfVerticalIntersection;

		///<summary>
		///
		///</summary>
		public void Set_GradeBreak(string pVal) 
		{
			this._i.GradeBreak = pVal;
		}

		///<summary>
		///
		///</summary>
		public string GradeBreak => this._i.GradeBreak;

		///<summary>
		///
		///</summary>
		public void Set_BeginVerticalCurve(string pVal) 
		{
			this._i.BeginVerticalCurve = pVal;
		}

		///<summary>
		///
		///</summary>
		public string BeginVerticalCurve => this._i.BeginVerticalCurve;

		///<summary>
		///
		///</summary>
		public void Set_BeginVerticalCurveStation(string pVal) 
		{
			this._i.BeginVerticalCurveStation = pVal;
		}

		///<summary>
		///
		///</summary>
		public string BeginVerticalCurveStation => this._i.BeginVerticalCurveStation;

		///<summary>
		///
		///</summary>
		public void Set_BeginVerticalCurveElevation(string pVal) 
		{
			this._i.BeginVerticalCurveElevation = pVal;
		}

		///<summary>
		///
		///</summary>
		public string BeginVerticalCurveElevation => this._i.BeginVerticalCurveElevation;

		///<summary>
		///
		///</summary>
		public void Set_EndVerticalCurve(string pVal) 
		{
			this._i.EndVerticalCurve = pVal;
		}

		///<summary>
		///
		///</summary>
		public string EndVerticalCurve => this._i.EndVerticalCurve;

		///<summary>
		///
		///</summary>
		public void Set_EndVerticalCurveStation(string pVal) 
		{
			this._i.EndVerticalCurveStation = pVal;
		}

		///<summary>
		///
		///</summary>
		public string EndVerticalCurveStation => this._i.EndVerticalCurveStation;

		///<summary>
		///
		///</summary>
		public void Set_EndVerticalCurveElevation(string pVal) 
		{
			this._i.EndVerticalCurveElevation = pVal;
		}

		///<summary>
		///
		///</summary>
		public string EndVerticalCurveElevation => this._i.EndVerticalCurveElevation;

		///<summary>
		///
		///</summary>
		public void Set_HighPoint(string pVal) 
		{
			this._i.HighPoint = pVal;
		}

		///<summary>
		///
		///</summary>
		public string HighPoint => this._i.HighPoint;

		///<summary>
		///
		///</summary>
		public void Set_LowPoint(string pVal) 
		{
			this._i.LowPoint = pVal;
		}

		///<summary>
		///
		///</summary>
		public string LowPoint => this._i.LowPoint;

		///<summary>
		///
		///</summary>
		public void Set_CurveCoefficient(string pVal) 
		{
			this._i.CurveCoefficient = pVal;
		}

		///<summary>
		///
		///</summary>
		public string CurveCoefficient => this._i.CurveCoefficient;

		///<summary>
		///
		///</summary>
		public void Set_GradeChange(string pVal) 
		{
			this._i.GradeChange = pVal;
		}

		///<summary>
		///
		///</summary>
		public string GradeChange => this._i.GradeChange;

		///<summary>
		///
		///</summary>
		public void Set_ProfileStart(string pVal) 
		{
			this._i.ProfileStart = pVal;
		}

		///<summary>
		///
		///</summary>
		public string ProfileStart => this._i.ProfileStart;

		///<summary>
		///
		///</summary>
		public void Set_ProfileEnd(string pVal) 
		{
			this._i.ProfileEnd = pVal;
		}

		///<summary>
		///
		///</summary>
		public string ProfileEnd => this._i.ProfileEnd;

		///<summary>
		///
		///</summary>
		public void Set_VerticalCompoundCurveIntersect(string pVal) 
		{
			this._i.VerticalCompoundCurveIntersect = pVal;
		}

		///<summary>
		///
		///</summary>
		public string VerticalCompoundCurveIntersect => this._i.VerticalCompoundCurveIntersect;

		///<summary>
		///
		///</summary>
		public void Set_VerticalCompoundCurveIntersectStation(string pVal) 
		{
			this._i.VerticalCompoundCurveIntersectStation = pVal;
		}

		///<summary>
		///
		///</summary>
		public string VerticalCompoundCurveIntersectStation => this._i.VerticalCompoundCurveIntersectStation;

		///<summary>
		///
		///</summary>
		public void Set_VerticalCompoundCurveIntersectElevation(string pVal) 
		{
			this._i.VerticalCompoundCurveIntersectElevation = pVal;
		}

		///<summary>
		///
		///</summary>
		public string VerticalCompoundCurveIntersectElevation => this._i.VerticalCompoundCurveIntersectElevation;

		///<summary>
		///
		///</summary>
		public void Set_VerticalReverseCurveIntersect(string pVal) 
		{
			this._i.VerticalReverseCurveIntersect = pVal;
		}

		///<summary>
		///
		///</summary>
		public string VerticalReverseCurveIntersect => this._i.VerticalReverseCurveIntersect;

		///<summary>
		///
		///</summary>
		public void Set_VerticalReverseCurveIntersectStation(string pVal) 
		{
			this._i.VerticalReverseCurveIntersectStation = pVal;
		}

		///<summary>
		///
		///</summary>
		public string VerticalReverseCurveIntersectStation => this._i.VerticalReverseCurveIntersectStation;

		///<summary>
		///
		///</summary>
		public void Set_VerticalReverseCurveIntersectElevation(string pVal) 
		{
			this._i.VerticalReverseCurveIntersectElevation = pVal;
		}

		///<summary>
		///
		///</summary>
		public string VerticalReverseCurveIntersectElevation => this._i.VerticalReverseCurveIntersectElevation;

		///<summary>
		///
		///</summary>
		public void Set_OverallHighPoint(string pVal) 
		{
			this._i.OverallHighPoint = pVal;
		}

		///<summary>
		///
		///</summary>
		public string OverallHighPoint => this._i.OverallHighPoint;

		///<summary>
		///
		///</summary>
		public void Set_OverallLowPoint(string pVal) 
		{
			this._i.OverallLowPoint = pVal;
		}

		///<summary>
		///
		///</summary>
		public string OverallLowPoint => this._i.OverallLowPoint;
	}
}
