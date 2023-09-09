namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumRadiusLookupMethod 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumRadiusLookupMethod _i;
		internal AeccPropertyEnumRadiusLookupMethod(object AeccPropertyEnumRadiusLookupMethod_object) 
		{
			this._i = AeccPropertyEnumRadiusLookupMethod_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumRadiusLookupMethod;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccRadiusLookupMethodType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
