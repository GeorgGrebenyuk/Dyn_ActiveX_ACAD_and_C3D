namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentStations 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentStations _i;
		internal AeccAlignmentStations(object AeccAlignmentStations_object) 
		{
			this._i = AeccAlignmentStations_object as Autodesk.AECC.Interop.Land.IAeccAlignmentStations;
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
