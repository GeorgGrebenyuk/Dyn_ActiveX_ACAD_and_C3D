namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeNetworks 
	{
		public AeccXPipeLib.IAeccPipeNetworks _i;
		internal AeccPipeNetworks(object AeccPipeNetworks_object) 
		{
			this._i = AeccPipeNetworks_object as AeccXPipeLib.IAeccPipeNetworks;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(string bstrName) 
		{
			return this._i.Add(bstrName);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object varIndexOrName) 
		{
			this._i.Remove(varIndexOrName);
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
	}
}
