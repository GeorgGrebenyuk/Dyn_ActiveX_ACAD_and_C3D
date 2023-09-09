namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwayDatabase 
	{
		public AeccXRoadwayLib.IAeccRoadwayDatabase _i;
		internal AeccRoadwayDatabase(object AeccRoadwayDatabase_object) 
		{
			this._i = AeccRoadwayDatabase_object as AeccXRoadwayLib.IAeccRoadwayDatabase;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Corridors => this._i.Corridors;

		///<summary>
		///
		///</summary>
		public dynamic Assemblies => this._i.Assemblies;

		///<summary>
		///
		///</summary>
		public dynamic Subassemblies => this._i.Subassemblies;

		///<summary>
		///
		///</summary>
		public dynamic LinkStyles => this._i.LinkStyles;

		///<summary>
		///
		///</summary>
		public dynamic ShapeStyles => this._i.ShapeStyles;

		///<summary>
		///
		///</summary>
		public dynamic StyleSets => this._i.StyleSets;

		///<summary>
		///
		///</summary>
		public dynamic AssemblyStyles => this._i.AssemblyStyles;

		///<summary>
		///
		///</summary>
		public dynamic RoadwayState => this._i.RoadwayState;
	}
}
