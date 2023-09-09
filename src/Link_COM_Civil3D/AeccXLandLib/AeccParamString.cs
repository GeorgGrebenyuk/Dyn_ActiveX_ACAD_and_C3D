namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParamString 
	{
		public Autodesk.AECC.Interop.Land.IAeccParamString _i;
		internal AeccParamString(object AeccParamString_object) 
		{
			this._i = AeccParamString_object as Autodesk.AECC.Interop.Land.IAeccParamString;
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
		public void Set_TypeInfo(Autodesk.AECC.Interop.Land.AeccTypeInfoString pVal) 
		{
			this._i.TypeInfo = pVal;
		}
	}
}
