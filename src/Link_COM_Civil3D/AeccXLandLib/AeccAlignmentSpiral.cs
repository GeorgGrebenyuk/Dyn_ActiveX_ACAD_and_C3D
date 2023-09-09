namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSpiral 
	{
		public AeccXLandLib.IAeccAlignmentSpiral _i;
		internal AeccAlignmentSpiral(object AeccAlignmentSpiral_object) 
		{
			this._i = AeccAlignmentSpiral_object as AeccXLandLib.IAeccAlignmentSpiral;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double RadiusIn => this._i.RadiusIn;

		///<summary>
		///
		///</summary>
		public double RadiusOut => this._i.RadiusOut;

		///<summary>
		///
		///</summary>
		public double TotalY => this._i.TotalY;

		///<summary>
		///
		///</summary>
		public double TotalX => this._i.TotalX;

		///<summary>
		///
		///</summary>
		public double ShortTangent => this._i.ShortTangent;

		///<summary>
		///
		///</summary>
		public double LongTangent => this._i.LongTangent;

		///<summary>
		///
		///</summary>
		public double P => this._i.P;

		///<summary>
		///
		///</summary>
		public double K => this._i.K;

		///<summary>
		///
		///</summary>
		public double A => this._i.A;

		///<summary>
		///
		///</summary>
		public void Set_A(double A) 
		{
			this._i.A = A;
		}

		///<summary>
		///
		///</summary>
		public dynamic Curvature => this._i.Curvature;

		///<summary>
		///
		///</summary>
		public bool Compound => this._i.Compound;

		///<summary>
		///
		///</summary>
		public dynamic SpiralType => this._i.SpiralType;

		///<summary>
		///
		///</summary>
		public dynamic SpiralConstraint => this._i.SpiralConstraint;

		///<summary>
		///
		///</summary>
		public double RadialNorthing => this._i.RadialNorthing;

		///<summary>
		///
		///</summary>
		public double RadialEasting => this._i.RadialEasting;

		///<summary>
		///
		///</summary>
		public double SPIStation => this._i.SPIStation;

		///<summary>
		///
		///</summary>
		public double SPIAngle => this._i.SPIAngle;

		///<summary>
		///
		///</summary>
		public double SPINorthing => this._i.SPINorthing;

		///<summary>
		///
		///</summary>
		public double SPIEasting => this._i.SPIEasting;

		///<summary>
		///
		///</summary>
		public double StartDirection => this._i.StartDirection;

		///<summary>
		///
		///</summary>
		public double EndDirection => this._i.EndDirection;

		///<summary>
		///
		///</summary>
		public dynamic Direction => this._i.Direction;

		///<summary>
		///
		///</summary>
		public double Delta => this._i.Delta;

		///<summary>
		///
		///</summary>
		public string CurveGroupIndex => this._i.CurveGroupIndex;

		///<summary>
		///
		///</summary>
		public void Set_CurveGroupIndex(string pVal) 
		{
			this._i.CurveGroupIndex = pVal;
		}

		///<summary>
		///
		///</summary>
		public string CurveGroupSubEntityIndex => this._i.CurveGroupSubEntityIndex;

		///<summary>
		///
		///</summary>
		public void Set_CurveGroupSubEntityIndex(string pVal) 
		{
			this._i.CurveGroupSubEntityIndex = pVal;
		}

		///<summary>
		///
		///</summary>
		public double MinimumTransitionLength => this._i.MinimumTransitionLength;
	}
}
