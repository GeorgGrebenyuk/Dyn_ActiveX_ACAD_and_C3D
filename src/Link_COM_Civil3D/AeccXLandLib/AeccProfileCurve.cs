namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileCurve 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileCurve _i;
		internal AeccProfileCurve(object AeccProfileCurve_object) 
		{
			this._i = AeccProfileCurve_object as Autodesk.AECC.Interop.Land.IAeccProfileCurve;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double Length => this._i.Length;

		///<summary>
		///
		///</summary>
		public void Set_Length(double pdLength) 
		{
			this._i.Length = pdLength;
		}

		///<summary>
		///
		///</summary>
		public double StartStation => this._i.StartStation;

		///<summary>
		///
		///</summary>
		public double StartElevation => this._i.StartElevation;

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
