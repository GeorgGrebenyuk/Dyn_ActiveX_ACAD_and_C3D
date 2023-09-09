namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCorridorCodes 
	{
		public AeccXRoadwayLib.IAeccCorridorCodes _i;
		internal AeccCorridorCodes(object AeccCorridorCodes_object) 
		{
			this._i = AeccCorridorCodes_object as AeccXRoadwayLib.IAeccCorridorCodes;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Corridor => this._i.Corridor;

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
