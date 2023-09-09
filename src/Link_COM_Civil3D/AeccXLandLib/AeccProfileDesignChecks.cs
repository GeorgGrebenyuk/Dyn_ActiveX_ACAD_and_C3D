namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileDesignChecks 
	{
		public AeccXLandLib.IAeccProfileDesignChecks _i;
		internal AeccProfileDesignChecks(object AeccProfileDesignChecks_object) 
		{
			this._i = AeccProfileDesignChecks_object as AeccXLandLib.IAeccProfileDesignChecks;
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
		public void Add(dynamic Id) 
		{
			this._i.Add(Id);
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
