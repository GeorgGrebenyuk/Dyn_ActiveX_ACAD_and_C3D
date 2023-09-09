namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGraphProfileNetworkParts 
	{
		public AeccXPipeLib.IAeccGraphProfileNetworkParts _i;
		internal AeccGraphProfileNetworkParts(object AeccGraphProfileNetworkParts_object) 
		{
			this._i = AeccGraphProfileNetworkParts_object as AeccXPipeLib.IAeccGraphProfileNetworkParts;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object Name) 
		{
			this._i.Remove(Name);
		}
	}
}
