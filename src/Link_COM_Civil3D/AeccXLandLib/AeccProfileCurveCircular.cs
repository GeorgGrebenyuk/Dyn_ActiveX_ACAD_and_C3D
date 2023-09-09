namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileCurveCircular 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileCurveCircular _i;
		internal AeccProfileCurveCircular(object AeccProfileCurveCircular_object) 
		{
			this._i = AeccProfileCurveCircular_object as Autodesk.AECC.Interop.Land.IAeccProfileCurveCircular;
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
		public void Set_M(double pdM) 
		{
			this._i.M = pdM;
		}
	}
}
