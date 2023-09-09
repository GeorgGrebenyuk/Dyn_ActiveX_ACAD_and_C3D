namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCorridorSurfaces 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccCorridorSurfaces _i;
		internal AeccCorridorSurfaces(object AeccCorridorSurfaces_object) 
		{
			this._i = AeccCorridorSurfaces_object as Autodesk.AECC.Interop.Roadway.IAeccCorridorSurfaces;
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
		public string SurfaceNames => this._i.SurfaceNames;

		///<summary>
		///
		///</summary>
		public dynamic Item(object IndexOrName) 
		{
			return this._i.Item(IndexOrName);
		}
	}
}
