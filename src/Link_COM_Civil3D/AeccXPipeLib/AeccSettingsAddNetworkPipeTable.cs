namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddNetworkPipeTable 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsAddNetworkPipeTable _i;
		internal AeccSettingsAddNetworkPipeTable(object AeccSettingsAddNetworkPipeTable_object) 
		{
			this._i = AeccSettingsAddNetworkPipeTable_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsAddNetworkPipeTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
