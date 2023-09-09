namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCalculatedLinks 
	{
		public AeccXRoadwayLib.IAeccCalculatedLinks _i;
		internal AeccCalculatedLinks(object AeccCalculatedLinks_object) 
		{
			this._i = AeccCalculatedLinks_object as AeccXRoadwayLib.IAeccCalculatedLinks;
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
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}
	}
}
