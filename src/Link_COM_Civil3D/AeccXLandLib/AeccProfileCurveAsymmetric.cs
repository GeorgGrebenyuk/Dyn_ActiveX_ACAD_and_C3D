namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileCurveAsymmetric 
	{
		public AeccXLandLib.IAeccProfileCurveAsymmetric _i;
		internal AeccProfileCurveAsymmetric(object AeccProfileCurveAsymmetric_object) 
		{
			this._i = AeccProfileCurveAsymmetric_object as AeccXLandLib.IAeccProfileCurveAsymmetric;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CurveType => this._i.CurveType;

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
		public double AsymmetricLength1 => this._i.AsymmetricLength1;

		///<summary>
		///
		///</summary>
		public void Set_AsymmetricLength1(double pdLength) 
		{
			this._i.AsymmetricLength1 = pdLength;
		}

		///<summary>
		///
		///</summary>
		public double AsymmetricLength2 => this._i.AsymmetricLength2;

		///<summary>
		///
		///</summary>
		public void Set_AsymmetricLength2(double pdLength) 
		{
			this._i.AsymmetricLength2 = pdLength;
		}
	}
}
