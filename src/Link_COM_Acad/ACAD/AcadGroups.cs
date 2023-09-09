namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadGroups 
	{
		public AXDBLib.IAcadGroups _i;
		internal AcadGroups(object AcadGroups_object) 
		{
			this._i = AcadGroups_object as AXDBLib.IAcadGroups;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

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
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add(string Name) 
		{
			return this._i.Add(Name);
		}
	}
}
