namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumRadiusLookupMethod 
	{
		public AeccXLandLib.IAeccPropertyEnumRadiusLookupMethod _i;
		internal AeccPropertyEnumRadiusLookupMethod(object AeccPropertyEnumRadiusLookupMethod_object) 
		{
			this._i = AeccPropertyEnumRadiusLookupMethod_object as AeccXLandLib.IAeccPropertyEnumRadiusLookupMethod;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccRadiusLookupMethodType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
