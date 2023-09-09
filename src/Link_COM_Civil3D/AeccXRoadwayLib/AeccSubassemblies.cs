namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSubassemblies 
	{
		public AeccXRoadwayLib.IAeccSubassemblies _i;
		internal AeccSubassemblies(object AeccSubassemblies_object) 
		{
			this._i = AeccSubassemblies_object as AeccXRoadwayLib.IAeccSubassemblies;
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
