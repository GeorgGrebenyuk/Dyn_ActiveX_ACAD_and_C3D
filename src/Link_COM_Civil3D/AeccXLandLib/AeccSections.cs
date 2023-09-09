namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSections 
	{
		public Autodesk.AECC.Interop.Land.IAeccSections _i;
		internal AeccSections(object AeccSections_object) 
		{
			this._i = AeccSections_object as Autodesk.AECC.Interop.Land.IAeccSections;
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
		public void Remove(object Index) 
		{
			this._i.Remove(Index);
		}
	}
}
