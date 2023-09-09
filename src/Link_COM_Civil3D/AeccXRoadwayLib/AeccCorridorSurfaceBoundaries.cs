namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCorridorSurfaceBoundaries 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccCorridorSurfaceBoundaries _i;
		internal AeccCorridorSurfaceBoundaries(object AeccCorridorSurfaceBoundaries_object) 
		{
			this._i = AeccCorridorSurfaceBoundaries_object as Autodesk.AECC.Interop.Roadway.IAeccCorridorSurfaceBoundaries;
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
		public string BoundaryNames => this._i.BoundaryNames;

		///<summary>
		///
		///</summary>
		public dynamic Item(object IndexOrName) 
		{
			return this._i.Item(IndexOrName);
		}
	}
}
