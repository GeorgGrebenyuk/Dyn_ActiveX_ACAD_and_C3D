namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParamString 
	{
		public AeccXLandLib.IAeccParamString _i;
		internal AeccParamString(object AeccParamString_object) 
		{
			this._i = AeccParamString_object as AeccXLandLib.IAeccParamString;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(string pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic TypeInfo => this._i.TypeInfo;

		///<summary>
		///
		///</summary>
		public void Set_TypeInfo(AeccXLandLib.AeccTypeInfoString pVal) 
		{
			this._i.TypeInfo = pVal;
		}
	}
}
