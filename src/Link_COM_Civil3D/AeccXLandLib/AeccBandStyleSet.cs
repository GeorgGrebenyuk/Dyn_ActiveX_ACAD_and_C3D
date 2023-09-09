namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBandStyleSet 
	{
		public AeccXLandLib.IAeccBandStyleSet _i;
		internal AeccBandStyleSet(object AeccBandStyleSet_object) 
		{
			this._i = AeccBandStyleSet_object as AeccXLandLib.IAeccBandStyleSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(dynamic pIBandStyle) 
		{
			return this._i.Add(pIBandStyle);
		}

		///<summary>
		///
		///</summary>
		public void Remove(dynamic Index) 
		{
			this._i.Remove(Index);
		}
	}
}
