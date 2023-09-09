namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsRenamePipeNetworkParts 
	{
		public AeccXPipeLib.IAeccSettingsRenamePipeNetworkParts _i;
		internal AeccSettingsRenamePipeNetworkParts(object AeccSettingsRenamePipeNetworkParts_object) 
		{
			this._i = AeccSettingsRenamePipeNetworkParts_object as AeccXPipeLib.IAeccSettingsRenamePipeNetworkParts;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
