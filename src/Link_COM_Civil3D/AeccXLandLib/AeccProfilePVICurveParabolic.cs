namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfilePVICurveParabolic 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfilePVICurveParabolic _i;
		internal AeccProfilePVICurveParabolic(object AeccProfilePVICurveParabolic_object) 
		{
			this._i = AeccProfilePVICurveParabolic_object as Autodesk.AECC.Interop.Land.IAeccProfilePVICurveParabolic;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

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
		public double Radius => this._i.Radius;

		///<summary>
		///
		///</summary>
		public void Set_PassThroughPoint(object ptpoint) 
		{
			this._i.PassThroughPoint = ptpoint;
		}

		///<summary>
		///
		///</summary>
		public object PassThroughPoint => this._i.PassThroughPoint;

		///<summary>
		///
		///</summary>
		public void Set_K(double kvalue) 
		{
			this._i.K = kvalue;
		}

		///<summary>
		///
		///</summary>
		public double K => this._i.K;

		///<summary>
		///
		///</summary>
		public void Set_PassingSightDistance(double pdPassingSightDistance) 
		{
			this._i.PassingSightDistance = pdPassingSightDistance;
		}

		///<summary>
		///
		///</summary>
		public double PassingSightDistance => this._i.PassingSightDistance;

		///<summary>
		///
		///</summary>
		public void Set_StoppingSightDistance(double pdPassingSightDistance) 
		{
			this._i.StoppingSightDistance = pdPassingSightDistance;
		}

		///<summary>
		///
		///</summary>
		public double StoppingSightDistance => this._i.StoppingSightDistance;

		///<summary>
		///
		///</summary>
		public void Set_HeadlightSightDistance(double hsd) 
		{
			this._i.HeadlightSightDistance = hsd;
		}

		///<summary>
		///
		///</summary>
		public double HeadlightSightDistance => this._i.HeadlightSightDistance;
	}
}
