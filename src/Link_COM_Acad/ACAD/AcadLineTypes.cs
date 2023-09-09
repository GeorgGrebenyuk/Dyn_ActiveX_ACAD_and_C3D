namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadLineTypes 
	{
		public AXDBLib.IAcadLineTypes _i;
		internal AcadLineTypes(object AcadLineTypes_object) 
		{
			this._i = AcadLineTypes_object as AXDBLib.IAcadLineTypes;
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

		///<summary>
		///
		///</summary>
		public void Load(string Name,string FileName) 
		{
			this._i.Load(Name,FileName);
		}
	}
}
