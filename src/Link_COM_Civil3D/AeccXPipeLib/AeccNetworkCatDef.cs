namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccNetworkCatDef 
	{
		public AeccXPipeLib.IAeccNetworkCatDef _i;
		internal AeccNetworkCatDef(object AeccNetworkCatDef_object) 
		{
			this._i = AeccNetworkCatDef_object as AeccXPipeLib.IAeccNetworkCatDef;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void DeclareNewParameter(string bstrGlobalContext,string bstrDisplayContext,string bstrParamName,string bstrParamDesc,AeccXPipeLib.AeccPartDataFieldType eDataType,AeccXPipeLib.AeccPipeNetworkUsage eUsage,string bstrDefaultUnits,bool bSingleton,bool bCatManagedList) 
		{
			this._i.DeclareNewParameter(bstrGlobalContext,bstrDisplayContext,bstrParamName,bstrParamDesc,eDataType,eUsage,bstrDefaultUnits,bSingleton,bCatManagedList);
		}

		///<summary>
		///
		///</summary>
		public void DeclarePartProperty(string bstrGlobalContext,AeccXPipeLib.AeccPipeNetworkDomain eDomain,int nPartType) 
		{
			this._i.DeclarePartProperty(bstrGlobalContext,eDomain,nPartType);
		}
	}
}
