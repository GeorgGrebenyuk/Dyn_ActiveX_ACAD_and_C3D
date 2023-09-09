namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAssemblies 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccAssemblies _i;
		internal AeccAssemblies(object AeccAssemblies_object) 
		{
			this._i = AeccAssemblies_object as Autodesk.AECC.Interop.Roadway.IAeccAssemblies;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

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
