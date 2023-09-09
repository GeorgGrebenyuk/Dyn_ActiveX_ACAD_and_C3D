namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGraphProfileNetworkPart 
	{
		public AeccXPipeLib.IAeccGraphProfileNetworkPart _i;
		internal AeccGraphProfileNetworkPart(object AeccGraphProfileNetworkPart_object) 
		{
			this._i = AeccGraphProfileNetworkPart_object as AeccXPipeLib.IAeccGraphProfileNetworkPart;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic GetModelNetworkPart => this._i.GetModelNetworkPart;

		///<summary>
		///
		///</summary>
		public dynamic Labels => this._i.Labels;
	}
}
