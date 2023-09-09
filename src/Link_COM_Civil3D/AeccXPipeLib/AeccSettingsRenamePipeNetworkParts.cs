namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsRenamePipeNetworkParts 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsRenamePipeNetworkParts _i;
		internal AeccSettingsRenamePipeNetworkParts(object AeccSettingsRenamePipeNetworkParts_object) 
		{
			this._i = AeccSettingsRenamePipeNetworkParts_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsRenamePipeNetworkParts;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
