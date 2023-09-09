namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccWatershedRegionDepression 
	{
		public Autodesk.AECC.Interop.Land.IAeccWatershedRegionDepression _i;
		internal AeccWatershedRegionDepression(object AeccWatershedRegionDepression_object) 
		{
			this._i = AeccWatershedRegionDepression_object as Autodesk.AECC.Interop.Land.IAeccWatershedRegionDepression;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Drains => this._i.Drains;
	}
}
