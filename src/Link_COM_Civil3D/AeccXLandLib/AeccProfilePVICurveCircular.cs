namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfilePVICurveCircular 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfilePVICurveCircular _i;
		internal AeccProfilePVICurveCircular(object AeccProfilePVICurveCircular_object) 
		{
			this._i = AeccProfilePVICurveCircular_object as Autodesk.AECC.Interop.Land.IAeccProfilePVICurveCircular;
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
	}
}
