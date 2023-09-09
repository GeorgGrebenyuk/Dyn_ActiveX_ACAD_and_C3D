namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSites 
	{
		public AeccXLandLib.IAeccSites _i;
		internal AeccSites(object AeccSites_object) 
		{
			this._i = AeccSites_object as AeccXLandLib.IAeccSites;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

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
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add(string Name) 
		{
			return this._i.Add(Name);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object Index) 
		{
			this._i.Remove(Index);
		}
	}
}
