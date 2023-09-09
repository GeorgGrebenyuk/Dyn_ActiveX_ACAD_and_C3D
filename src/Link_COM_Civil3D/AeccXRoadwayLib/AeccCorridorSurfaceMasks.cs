namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCorridorSurfaceMasks 
	{
		public AeccXRoadwayLib.IAeccCorridorSurfaceMasks _i;
		internal AeccCorridorSurfaceMasks(object AeccCorridorSurfaceMasks_object) 
		{
			this._i = AeccCorridorSurfaceMasks_object as AeccXRoadwayLib.IAeccCorridorSurfaceMasks;
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
		public string MaskNames => this._i.MaskNames;

		///<summary>
		///
		///</summary>
		public dynamic Item(object IndexOrName) 
		{
			return this._i.Item(IndexOrName);
		}
	}
}
