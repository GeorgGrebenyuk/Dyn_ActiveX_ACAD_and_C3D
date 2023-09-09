namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccOffsetBaselines 
	{
		public AeccXRoadwayLib.IAeccOffsetBaselines _i;
		internal AeccOffsetBaselines(object AeccOffsetBaselines_object) 
		{
			this._i = AeccOffsetBaselines_object as AeccXRoadwayLib.IAeccOffsetBaselines;
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
		public string OffsetBaselineNames => this._i.OffsetBaselineNames;

		///<summary>
		///
		///</summary>
		public dynamic Item(object IndexOrName) 
		{
			return this._i.Item(IndexOrName);
		}
	}
}
