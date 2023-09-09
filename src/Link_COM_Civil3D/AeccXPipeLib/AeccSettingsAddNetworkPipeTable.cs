namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddNetworkPipeTable 
	{
		public AeccXPipeLib.IAeccSettingsAddNetworkPipeTable _i;
		internal AeccSettingsAddNetworkPipeTable(object AeccSettingsAddNetworkPipeTable_object) 
		{
			this._i = AeccSettingsAddNetworkPipeTable_object as AeccXPipeLib.IAeccSettingsAddNetworkPipeTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
