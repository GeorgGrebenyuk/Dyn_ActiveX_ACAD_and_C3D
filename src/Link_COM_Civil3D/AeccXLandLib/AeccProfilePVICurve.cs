namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfilePVICurve 
	{
		public AeccXLandLib.IAeccProfilePVICurve _i;
		internal AeccProfilePVICurve(object AeccProfilePVICurve_object) 
		{
			this._i = AeccProfilePVICurve_object as AeccXLandLib.IAeccProfilePVICurve;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic EntityType => this._i.EntityType;

		///<summary>
		///
		///</summary>
		public void Set_CurveLength(double CurveLength) 
		{
			this._i.CurveLength = CurveLength;
		}

		///<summary>
		///
		///</summary>
		public double CurveLength => this._i.CurveLength;

		///<summary>
		///
		///</summary>
		public dynamic VerticalCurveType => this._i.VerticalCurveType;

		///<summary>
		///
		///</summary>
		public dynamic VerticalConstraintType => this._i.VerticalConstraintType;

		///<summary>
		///
		///</summary>
		public double GradeChange => this._i.GradeChange;

		///<summary>
		///
		///</summary>
		public double BeginStation => this._i.BeginStation;

		///<summary>
		///
		///</summary>
		public double BeginElevation => this._i.BeginElevation;

		///<summary>
		///
		///</summary>
		public double EndStation => this._i.EndStation;

		///<summary>
		///
		///</summary>
		public double EndElevation => this._i.EndElevation;

		///<summary>
		///
		///</summary>
		public double HighPointStation => this._i.HighPointStation;

		///<summary>
		///
		///</summary>
		public double LowPointStation => this._i.LowPointStation;

		///<summary>
		///
		///</summary>
		public double HighPointElevation => this._i.HighPointElevation;

		///<summary>
		///
		///</summary>
		public double LowPointElevation => this._i.LowPointElevation;

		///<summary>
		///
		///</summary>
		public double TangentLengthBefore => this._i.TangentLengthBefore;

		///<summary>
		///
		///</summary>
		public double TangentLengthAfter => this._i.TangentLengthAfter;

		///<summary>
		///
		///</summary>
		public void ValidateDesignCheck(dynamic pDesignCheck,out bool pVal) 
		{
			this._i.ValidateDesignCheck(pDesignCheck,out pVal);
		}

		///<summary>
		///
		///</summary>
		public dynamic DesignChecks => this._i.DesignChecks;

		///<summary>
		///
		///</summary>
		public double HighestDesignSpeed => this._i.HighestDesignSpeed;

		///<summary>
		///
		///</summary>
		public double MinimumKValueSSD => this._i.MinimumKValueSSD;

		///<summary>
		///
		///</summary>
		public double MinimumKValuePSD => this._i.MinimumKValuePSD;

		///<summary>
		///
		///</summary>
		public double MinimumKValueHSD => this._i.MinimumKValueHSD;
	}
}
