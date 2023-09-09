namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGeneralLabels 
	{
		public AeccXLandLib.IAeccGeneralLabels _i;
		internal AeccGeneralLabels(object AeccGeneralLabels_object) 
		{
			this._i = AeccGeneralLabels_object as AeccXLandLib.IAeccGeneralLabels;
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
		public void Remove(dynamic Index) 
		{
			this._i.Remove(Index);
		}
	}
}
