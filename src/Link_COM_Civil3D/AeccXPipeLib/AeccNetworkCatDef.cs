namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccNetworkCatDef 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccNetworkCatDef _i;
		internal AeccNetworkCatDef(object AeccNetworkCatDef_object) 
		{
			this._i = AeccNetworkCatDef_object as Autodesk.AECC.Interop.Pipe.IAeccNetworkCatDef;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void DeclareNewParameter(string bstrGlobalContext,string bstrDisplayContext,string bstrParamName,string bstrParamDesc,Autodesk.AECC.Interop.Pipe.AeccPartDataFieldType eDataType,Autodesk.AECC.Interop.Pipe.AeccPipeNetworkUsage eUsage,string bstrDefaultUnits,bool bSingleton,bool bCatManagedList) 
		{
			this._i.DeclareNewParameter(bstrGlobalContext,bstrDisplayContext,bstrParamName,bstrParamDesc,eDataType,eUsage,bstrDefaultUnits,bSingleton,bCatManagedList);
		}

		///<summary>
		///
		///</summary>
		public void DeclarePartProperty(string bstrGlobalContext,Autodesk.AECC.Interop.Pipe.AeccPipeNetworkDomain eDomain,int nPartType) 
		{
			this._i.DeclarePartProperty(bstrGlobalContext,eDomain,nPartType);
		}
	}
}
