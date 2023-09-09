namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadViews 
	{
		public AXDBLib.IAcadViews _i;
		internal AcadViews(object AcadViews_object) 
		{
			this._i = AcadViews_object as AXDBLib.IAcadViews;
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
