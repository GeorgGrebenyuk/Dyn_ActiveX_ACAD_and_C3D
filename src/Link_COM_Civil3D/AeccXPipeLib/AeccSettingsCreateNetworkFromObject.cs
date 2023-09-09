namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateNetworkFromObject 
	{
		public AeccXPipeLib.IAeccSettingsCreateNetworkFromObject _i;
		internal AeccSettingsCreateNetworkFromObject(object AeccSettingsCreateNetworkFromObject_object) 
		{
			this._i = AeccSettingsCreateNetworkFromObject_object as AeccXPipeLib.IAeccSettingsCreateNetworkFromObject;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
