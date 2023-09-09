namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateNetworkReference 
	{
		public AeccXPipeLib.IAeccSettingsCreateNetworkReference _i;
		internal AeccSettingsCreateNetworkReference(object AeccSettingsCreateNetworkReference_object) 
		{
			this._i = AeccSettingsCreateNetworkReference_object as AeccXPipeLib.IAeccSettingsCreateNetworkReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
