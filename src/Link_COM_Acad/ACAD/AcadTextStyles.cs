namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadTextStyles 
	{
		public AXDBLib.IAcadTextStyles _i;
		internal AcadTextStyles(object AcadTextStyles_object) 
		{
			this._i = AcadTextStyles_object as AXDBLib.IAcadTextStyles;
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
