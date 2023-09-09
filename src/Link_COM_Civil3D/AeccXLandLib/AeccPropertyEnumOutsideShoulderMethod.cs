namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumOutsideShoulderMethod 
	{
		public AeccXLandLib.IAeccPropertyEnumOutsideShoulderMethod _i;
		internal AeccPropertyEnumOutsideShoulderMethod(object AeccPropertyEnumOutsideShoulderMethod_object) 
		{
			this._i = AeccPropertyEnumOutsideShoulderMethod_object as AeccXLandLib.IAeccPropertyEnumOutsideShoulderMethod;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccOutsideShoulderMethodType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
