namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwayCodes 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccRoadwayCodes _i;
		internal AeccRoadwayCodes(object AeccRoadwayCodes_object) 
		{
			this._i = AeccRoadwayCodes_object as Autodesk.AECC.Interop.Roadway.IAeccRoadwayCodes;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Add(string bstrCode) 
		{
			this._i.Add(bstrCode);
		}

		///<summary>
		///
		///</summary>
		public void Remove(string bstrCode) 
		{
			this._i.Remove(bstrCode);
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public string Item(object Index) 
		{
			return this._i.Item(Index);
		}
	}
}
