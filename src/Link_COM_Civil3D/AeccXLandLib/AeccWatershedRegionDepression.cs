namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccWatershedRegionDepression 
	{
		public AeccXLandLib.IAeccWatershedRegionDepression _i;
		internal AeccWatershedRegionDepression(object AeccWatershedRegionDepression_object) 
		{
			this._i = AeccWatershedRegionDepression_object as AeccXLandLib.IAeccWatershedRegionDepression;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Drains => this._i.Drains;
	}
}
