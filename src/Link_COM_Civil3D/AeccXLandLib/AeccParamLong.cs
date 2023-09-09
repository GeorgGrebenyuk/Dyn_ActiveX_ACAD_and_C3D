namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParamLong 
	{
		public Autodesk.AECC.Interop.Land.IAeccParamLong _i;
		internal AeccParamLong(object AeccParamLong_object) 
		{
			this._i = AeccParamLong_object as Autodesk.AECC.Interop.Land.IAeccParamLong;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(dynamic pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public void EnumXmlIn(dynamic pElement) 
		{
			this._i.EnumXmlIn(pElement);
		}

		///<summary>
		///
		///</summary>
		public void EnumXmlOut(dynamic pElement) 
		{
			this._i.EnumXmlOut(pElement);
		}

		///<summary>
		///
		///</summary>
		public dynamic EnumCount => this._i.EnumCount;

		///<summary>
		///
		///</summary>
		public void GetEnumData(dynamic long,out string pbstrName,out string pbstrDisplayName,out dynamic pValue) 
		{
			this._i.GetEnumData(long,out pbstrName,out pbstrDisplayName,out pValue);
		}

		///<summary>
		///
		///</summary>
		public void AddEnumData(string bstrName,string bstrDisplayName,dynamic nValue) 
		{
			this._i.AddEnumData(bstrName,bstrDisplayName,nValue);
		}

		///<summary>
		///
		///</summary>
		public dynamic TypeInfo => this._i.TypeInfo;

		///<summary>
		///
		///</summary>
		public void Set_TypeInfo(Autodesk.AECC.Interop.Land.AeccTypeInfoLong pVal) 
		{
			this._i.TypeInfo = pVal;
		}
	}
}
