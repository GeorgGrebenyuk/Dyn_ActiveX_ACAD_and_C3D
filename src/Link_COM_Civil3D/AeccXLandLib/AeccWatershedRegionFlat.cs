namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccWatershedRegionFlat 
	{
		public AeccXLandLib.IAeccWatershedRegionFlat _i;
		internal AeccWatershedRegionFlat(object AeccWatershedRegionFlat_object) 
		{
			this._i = AeccWatershedRegionFlat_object as AeccXLandLib.IAeccWatershedRegionFlat;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string DrainsInto => this._i.DrainsInto;
	}
}
