namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumProximityDistScale 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPropertyEnumProximityDistScale _i;
		internal AeccPropertyEnumProximityDistScale(object AeccPropertyEnumProximityDistScale_object) 
		{
			this._i = AeccPropertyEnumProximityDistScale_object as Autodesk.AECC.Interop.Pipe.IAeccPropertyEnumProximityDistScale;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Pipe.AeccProximityDistanceScaleFactorOptions pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
