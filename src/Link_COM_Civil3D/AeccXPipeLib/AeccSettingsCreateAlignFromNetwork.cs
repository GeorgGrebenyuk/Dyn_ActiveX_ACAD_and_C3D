namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateAlignFromNetwork 
	{
		public AeccXPipeLib.IAeccSettingsCreateAlignFromNetwork _i;
		internal AeccSettingsCreateAlignFromNetwork(object AeccSettingsCreateAlignFromNetwork_object) 
		{
			this._i = AeccSettingsCreateAlignFromNetwork_object as AeccXPipeLib.IAeccSettingsCreateAlignFromNetwork;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
