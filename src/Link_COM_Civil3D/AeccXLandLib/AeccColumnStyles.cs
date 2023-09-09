namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccColumnStyles 
	{
		public AeccXLandLib.IAeccColumnStyles _i;
		internal AeccColumnStyles(object AeccColumnStyles_object) 
		{
			this._i = AeccColumnStyles_object as AeccXLandLib.IAeccColumnStyles;
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
