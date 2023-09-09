namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileTangent 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileTangent _i;
		internal AeccProfileTangent(object AeccProfileTangent_object) 
		{
			this._i = AeccProfileTangent_object as Autodesk.AECC.Interop.Land.IAeccProfileTangent;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double Grade => this._i.Grade;

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
		public double HighestDesignSpeed => this._i.HighestDesignSpeed;
	}
}
