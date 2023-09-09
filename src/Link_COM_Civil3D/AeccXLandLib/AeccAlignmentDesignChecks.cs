namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentDesignChecks 
	{
		public AeccXLandLib.IAeccAlignmentDesignChecks _i;
		internal AeccAlignmentDesignChecks(object AeccAlignmentDesignChecks_object) 
		{
			this._i = AeccAlignmentDesignChecks_object as AeccXLandLib.IAeccAlignmentDesignChecks;
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
