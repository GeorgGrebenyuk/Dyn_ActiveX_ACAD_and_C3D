namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccMarkerStyles 
	{
		public AeccXLandLib.IAeccMarkerStyles _i;
		internal AeccMarkerStyles(object AeccMarkerStyles_object) 
		{
			this._i = AeccMarkerStyles_object as AeccXLandLib.IAeccMarkerStyles;
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
