namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccDesignSpeeds 
	{
		public AeccXLandLib.IAeccDesignSpeeds _i;
		internal AeccDesignSpeeds(object AeccDesignSpeeds_object) 
		{
			this._i = AeccDesignSpeeds_object as AeccXLandLib.IAeccDesignSpeeds;
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
		public dynamic Add(double Station) 
		{
			return this._i.Add(Station);
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
