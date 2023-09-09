namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelAreaLabels 
	{
		public AeccXLandLib.IAeccParcelAreaLabels _i;
		internal AeccParcelAreaLabels(object AeccParcelAreaLabels_object) 
		{
			this._i = AeccParcelAreaLabels_object as AeccXLandLib.IAeccParcelAreaLabels;
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

		///<summary>
		///
		///</summary>
		public dynamic Add(object LabelStyle) 
		{
			return this._i.Add(LabelStyle);
		}
	}
}
