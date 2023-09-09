namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumNetworkLayout 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPropertyEnumNetworkLayout _i;
		internal AeccPropertyEnumNetworkLayout(object AeccPropertyEnumNetworkLayout_object) 
		{
			this._i = AeccPropertyEnumNetworkLayout_object as Autodesk.AECC.Interop.Pipe.IAeccPropertyEnumNetworkLayout;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Pipe.AeccNetworkLayoutType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
