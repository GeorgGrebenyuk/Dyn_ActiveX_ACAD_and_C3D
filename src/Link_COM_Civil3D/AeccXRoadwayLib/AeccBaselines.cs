namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBaselines 
	{
		public AeccXRoadwayLib.IAeccBaselines _i;
		internal AeccBaselines(object AeccBaselines_object) 
		{
			this._i = AeccBaselines_object as AeccXRoadwayLib.IAeccBaselines;
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
