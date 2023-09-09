namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddNetworkStructTable 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsAddNetworkStructTable _i;
		internal AeccSettingsAddNetworkStructTable(object AeccSettingsAddNetworkStructTable_object) 
		{
			this._i = AeccSettingsAddNetworkStructTable_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsAddNetworkStructTable;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
