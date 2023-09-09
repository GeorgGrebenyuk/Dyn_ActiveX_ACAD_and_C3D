namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcels 
	{
		public AeccXLandLib.IAeccParcels _i;
		internal AeccParcels(object AeccParcels_object) 
		{
			this._i = AeccParcels_object as AeccXLandLib.IAeccParcels;
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
		public dynamic Properties => this._i.Properties;

		///<summary>
		///
		///</summary>
		public dynamic Statistics => this._i.Statistics;
	}
}
