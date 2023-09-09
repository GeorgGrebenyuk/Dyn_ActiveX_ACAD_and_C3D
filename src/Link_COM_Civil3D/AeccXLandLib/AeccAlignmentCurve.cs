namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentCurve 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentCurve _i;
		internal AeccAlignmentCurve(object AeccAlignmentCurve_object) 
		{
			this._i = AeccAlignmentCurve_object as Autodesk.AECC.Interop.Land.IAeccAlignmentCurve;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double Length => this._i.Length;

		///<summary>
		///
		///</summary>
		public void Set_Length(double Length) 
		{
			this._i.Length = Length;
		}

		///<summary>
		///
		///</summary>
		public double StartEasting => this._i.StartEasting;

		///<summary>
		///
		///</summary>
		public double StartNorthing => this._i.StartNorthing;

		///<summary>
		///
		///</summary>
		public double EndEasting => this._i.EndEasting;

		///<summary>
		///
		///</summary>
		public double EndNorthing => this._i.EndNorthing;

		///<summary>
		///
		///</summary>
		public double StartingStation => this._i.StartingStation;

		///<summary>
		///
		///</summary>
		public double EndingStation => this._i.EndingStation;

		///<summary>
		///
		///</summary>
		public double PIEasting => this._i.PIEasting;

		///<summary>
		///
		///</summary>
		public double PINorthing => this._i.PINorthing;

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
	}
}
