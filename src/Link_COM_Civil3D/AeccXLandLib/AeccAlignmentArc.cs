namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentArc 
	{
		public AeccXLandLib.IAeccAlignmentArc _i;
		internal AeccAlignmentArc(object AeccAlignmentArc_object) 
		{
			this._i = AeccAlignmentArc_object as AeccXLandLib.IAeccAlignmentArc;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double CenterEasting => this._i.CenterEasting;

		///<summary>
		///
		///</summary>
		public void Set_CenterEasting(double CenterEasting) 
		{
			this._i.CenterEasting = CenterEasting;
		}

		///<summary>
		///
		///</summary>
		public double CenterNorthing => this._i.CenterNorthing;

		///<summary>
		///
		///</summary>
		public void Set_CenterNorthing(double CenterNorthing) 
		{
			this._i.CenterNorthing = CenterNorthing;
		}

		///<summary>
		///
		///</summary>
		public double Radius => this._i.Radius;

		///<summary>
		///
		///</summary>
		public void Set_Radius(double Radius) 
		{
			this._i.Radius = Radius;
		}

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
		public double Delta => this._i.Delta;

		///<summary>
		///
		///</summary>
		public void Set_Delta(double Delta) 
		{
			this._i.Delta = Delta;
		}

		///<summary>
		///
		///</summary>
		public double ChordLength => this._i.ChordLength;

		///<summary>
		///
		///</summary>
		public void Set_ChordLength(double ChordLength) 
		{
			this._i.ChordLength = ChordLength;
		}

		///<summary>
		///
		///</summary>
		public double ChordDirection => this._i.ChordDirection;

		///<summary>
		///
		///</summary>
		public double ExternalSecant => this._i.ExternalSecant;

		///<summary>
		///
		///</summary>
		public void Set_ExternalSecant(double ExternalSecant) 
		{
			this._i.ExternalSecant = ExternalSecant;
		}

		///<summary>
		///
		///</summary>
		public double MidOrdinate => this._i.MidOrdinate;

		///<summary>
		///
		///</summary>
		public void Set_MidOrdinate(double MidOrdinate) 
		{
			this._i.MidOrdinate = MidOrdinate;
		}

		///<summary>
		///
		///</summary>
		public bool GreaterThan180 => this._i.GreaterThan180;

		///<summary>
		///
		///</summary>
		public void Set_GreaterThan180(bool bCWFlag) 
		{
			this._i.GreaterThan180 = bCWFlag;
		}

		///<summary>
		///
		///</summary>
		public double DeflectedAngle => this._i.DeflectedAngle;

		///<summary>
		///
		///</summary>
		public void Set_DeflectedAngle(double MidOrdinate) 
		{
			this._i.DeflectedAngle = MidOrdinate;
		}

		///<summary>
		///
		///</summary>
		public double PIStation => this._i.PIStation;

		///<summary>
		///
		///</summary>
		public dynamic CurveConstraint => this._i.CurveConstraint;

		///<summary>
		///
		///</summary>
		public double DirectionAtPoint1 => this._i.DirectionAtPoint1;

		///<summary>
		///
		///</summary>
		public void Set_DirectionAtPoint1(double pVal) 
		{
			this._i.DirectionAtPoint1 = pVal;
		}

		///<summary>
		///
		///</summary>
		public double DirectionAtPoint2 => this._i.DirectionAtPoint2;

		///<summary>
		///
		///</summary>
		public object PassThroughPoint1 => this._i.PassThroughPoint1;

		///<summary>
		///
		///</summary>
		public void Set_PassThroughPoint1(object pVal) 
		{
			this._i.PassThroughPoint1 = pVal;
		}

		///<summary>
		///
		///</summary>
		public object PassThroughPoint2 => this._i.PassThroughPoint2;

		///<summary>
		///
		///</summary>
		public void Set_PassThroughPoint2(object pVal) 
		{
			this._i.PassThroughPoint2 = pVal;
		}

		///<summary>
		///
		///</summary>
		public object PassThroughPoint3 => this._i.PassThroughPoint3;

		///<summary>
		///
		///</summary>
		public void Set_PassThroughPoint3(object pVal) 
		{
			this._i.PassThroughPoint3 = pVal;
		}

		///<summary>
		///
		///</summary>
		public double ExternalTangent => this._i.ExternalTangent;

		///<summary>
		///
		///</summary>
		public void Set_ExternalTangent(double ExternalTangent) 
		{
			this._i.ExternalTangent = ExternalTangent;
		}

		///<summary>
		///
		///</summary>
		public bool ReverseCurve => this._i.ReverseCurve;

		///<summary>
		///
		///</summary>
		public bool Clockwise => this._i.Clockwise;

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
		public double MinimumRadius => this._i.MinimumRadius;
	}
}
