namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCorridors 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccCorridors _i;
		internal AeccCorridors(object AeccCorridors_object) 
		{
			this._i = AeccCorridors_object as Autodesk.AECC.Interop.Roadway.IAeccCorridors;
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

		///<summary>
		///
		///</summary>
		public dynamic Add(string bstrCorridorName,string bstrAlignmentName,string bstrProfileName,string bstrAssemblyName) 
		{
			return this._i.Add(bstrCorridorName,bstrAlignmentName,bstrProfileName,bstrAssemblyName);
		}
	}
}
