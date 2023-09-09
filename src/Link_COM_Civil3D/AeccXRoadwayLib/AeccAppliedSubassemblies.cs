namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAppliedSubassemblies 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccAppliedSubassemblies _i;
		internal AeccAppliedSubassemblies(object AeccAppliedSubassemblies_object) 
		{
			this._i = AeccAppliedSubassemblies_object as Autodesk.AECC.Interop.Roadway.IAeccAppliedSubassemblies;
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
		public string ObjectIds => this._i.ObjectIds;

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}
	}
}
