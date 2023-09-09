namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumInsideShoulderMethod 
	{
		public AeccXLandLib.IAeccPropertyEnumInsideShoulderMethod _i;
		internal AeccPropertyEnumInsideShoulderMethod(object AeccPropertyEnumInsideShoulderMethod_object) 
		{
			this._i = AeccPropertyEnumInsideShoulderMethod_object as AeccXLandLib.IAeccPropertyEnumInsideShoulderMethod;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccInsideShoulderMethodType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
