namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGradingStyles 
	{
		public AeccXLandLib.IAeccGradingStyles _i;
		internal AeccGradingStyles(object AeccGradingStyles_object) 
		{
			this._i = AeccGradingStyles_object as AeccXLandLib.IAeccGradingStyles;
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
		public void Remove(object val) 
		{
			this._i.Remove(val);
		}
	}
}
