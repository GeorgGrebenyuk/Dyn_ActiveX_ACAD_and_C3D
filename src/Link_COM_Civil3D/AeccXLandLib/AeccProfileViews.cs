namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileViews 
	{
		public AeccXLandLib.IAeccProfileViews _i;
		internal AeccProfileViews(object AeccProfileViews_object) 
		{
			this._i = AeccProfileViews_object as AeccXLandLib.IAeccProfileViews;
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
		public dynamic Add(string Name,string Layer,object Origin,object vStyle,object vBandStyleSet) 
		{
			return this._i.Add(Name,Layer,Origin,vStyle,vBandStyleSet);
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
