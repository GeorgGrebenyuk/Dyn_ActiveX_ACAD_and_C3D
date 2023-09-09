namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumProximityDistScale 
	{
		public AeccXPipeLib.IAeccPropertyEnumProximityDistScale _i;
		internal AeccPropertyEnumProximityDistScale(object AeccPropertyEnumProximityDistScale_object) 
		{
			this._i = AeccPropertyEnumProximityDistScale_object as AeccXPipeLib.IAeccPropertyEnumProximityDistScale;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXPipeLib.AeccProximityDistanceScaleFactorOptions pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
