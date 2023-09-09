namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccWatershedRegions 
	{
		public AeccXLandLib.IAeccWatershedRegions _i;
		internal AeccWatershedRegions(object AeccWatershedRegions_object) 
		{
			this._i = AeccWatershedRegions_object as AeccXLandLib.IAeccWatershedRegions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic nIndex) 
		{
			return this._i.Item(nIndex);
		}

		///<summary>
		///
		///</summary>
		public dynamic Find(dynamic nWatershedRegionId) 
		{
			return this._i.Find(nWatershedRegionId);
		}
	}
}
