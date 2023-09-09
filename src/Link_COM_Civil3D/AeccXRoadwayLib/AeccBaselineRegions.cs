namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBaselineRegions 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccBaselineRegions _i;
		internal AeccBaselineRegions(object AeccBaselineRegions_object) 
		{
			this._i = AeccBaselineRegions_object as Autodesk.AECC.Interop.Roadway.IAeccBaselineRegions;
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
