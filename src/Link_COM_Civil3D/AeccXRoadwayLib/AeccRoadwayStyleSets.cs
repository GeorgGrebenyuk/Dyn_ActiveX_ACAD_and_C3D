namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwayStyleSets 
	{
		public AeccXRoadwayLib.IAeccRoadwayStyleSets _i;
		internal AeccRoadwayStyleSets(object AeccRoadwayStyleSets_object) 
		{
			this._i = AeccRoadwayStyleSets_object as AeccXRoadwayLib.IAeccRoadwayStyleSets;
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
		public dynamic Add(string Name) 
		{
			return this._i.Add(Name);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object val) 
		{
			this._i.Remove(val);
		}
	}
}
