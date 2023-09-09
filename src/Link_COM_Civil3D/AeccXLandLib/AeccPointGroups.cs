namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPointGroups 
	{
		public AeccXLandLib.IAeccPointGroups _i;
		internal AeccPointGroups(object AeccPointGroups_object) 
		{
			this._i = AeccPointGroups_object as AeccXLandLib.IAeccPointGroups;
			if (this._i == null) throw new System.Exception("Invalid casting");
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
