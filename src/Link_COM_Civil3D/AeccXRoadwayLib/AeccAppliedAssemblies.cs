namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAppliedAssemblies 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccAppliedAssemblies _i;
		internal AeccAppliedAssemblies(object AeccAppliedAssemblies_object) 
		{
			this._i = AeccAppliedAssemblies_object as Autodesk.AECC.Interop.Roadway.IAeccAppliedAssemblies;
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
		public string Stations => this._i.Stations;

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}
	}
}
