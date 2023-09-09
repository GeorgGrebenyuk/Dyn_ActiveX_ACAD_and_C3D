namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParamBool 
	{
		public AeccXLandLib.IAeccParamBool _i;
		internal AeccParamBool(object AeccParamBool_object) 
		{
			this._i = AeccParamBool_object as AeccXLandLib.IAeccParamBool;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(bool pVal) 
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
		public void Set_TypeInfo(AeccXLandLib.AeccTypeInfoBool pVal) 
		{
			this._i.TypeInfo = pVal;
		}
	}
}
