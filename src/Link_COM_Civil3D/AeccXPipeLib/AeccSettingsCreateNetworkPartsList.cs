namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateNetworkPartsList 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsCreateNetworkPartsList _i;
		internal AeccSettingsCreateNetworkPartsList(object AeccSettingsCreateNetworkPartsList_object) 
		{
			this._i = AeccSettingsCreateNetworkPartsList_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsCreateNetworkPartsList;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
