namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGroupPlotStyles 
	{
		public AeccXLandLib.IAeccGroupPlotStyles _i;
		internal AeccGroupPlotStyles(object AeccGroupPlotStyles_object) 
		{
			this._i = AeccGroupPlotStyles_object as AeccXLandLib.IAeccGroupPlotStyles;
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
		public dynamic Add(string Name) 
		{
			return this._i.Add(Name);
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
