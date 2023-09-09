namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccWatershedRegionMultiRegionDrain 
	{
		public AeccXLandLib.IAeccWatershedRegionMultiRegionDrain _i;
		internal AeccWatershedRegionMultiRegionDrain(object AeccWatershedRegionMultiRegionDrain_object) 
		{
			this._i = AeccWatershedRegionMultiRegionDrain_object as AeccXLandLib.IAeccWatershedRegionMultiRegionDrain;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string DrainsInto => this._i.DrainsInto;

		///<summary>
		///
		///</summary>
		public object DrainPoint => this._i.DrainPoint;
	}
}
