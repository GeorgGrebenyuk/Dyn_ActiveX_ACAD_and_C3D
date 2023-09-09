namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadBlocks 
	{
		public AXDBLib.IAcadBlocks _i;
		internal AcadBlocks(object AcadBlocks_object) 
		{
			this._i = AcadBlocks_object as AXDBLib.IAcadBlocks;
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
		public dynamic Add(object InsertionPoint,string Name) 
		{
			return this._i.Add(InsertionPoint,Name);
		}
	}
}
