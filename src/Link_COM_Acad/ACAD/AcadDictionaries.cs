namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadDictionaries 
	{
		public AXDBLib.IAcadDictionaries _i;
		internal AcadDictionaries(object AcadDictionaries_object) 
		{
			this._i = AcadDictionaries_object as AXDBLib.IAcadDictionaries;
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
