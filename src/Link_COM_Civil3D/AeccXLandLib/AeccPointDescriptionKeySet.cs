namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPointDescriptionKeySet 
	{
		public AeccXLandLib.IAeccPointDescriptionKeySet _i;
		internal AeccPointDescriptionKeySet(object AeccPointDescriptionKeySet_object) 
		{
			this._i = AeccPointDescriptionKeySet_object as AeccXLandLib.IAeccPointDescriptionKeySet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add(string Key) 
		{
			return this._i.Add(Key);
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
		public void Remove(object Index) 
		{
			this._i.Remove(Index);
		}
	}
}
