namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccWatershedRegionMultiRegionDrainNotch 
	{
		public Autodesk.AECC.Interop.Land.IAeccWatershedRegionMultiRegionDrainNotch _i;
		internal AeccWatershedRegionMultiRegionDrainNotch(object AeccWatershedRegionMultiRegionDrainNotch_object) 
		{
			this._i = AeccWatershedRegionMultiRegionDrainNotch_object as Autodesk.AECC.Interop.Land.IAeccWatershedRegionMultiRegionDrainNotch;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string DrainsInto => this._i.DrainsInto;

		///<summary>
		///
		///</summary>
		public object DrainSegment => this._i.DrainSegment;
	}
}
