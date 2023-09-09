namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccWatershedRegionFlat 
	{
		public Autodesk.AECC.Interop.Land.IAeccWatershedRegionFlat _i;
		internal AeccWatershedRegionFlat(object AeccWatershedRegionFlat_object) 
		{
			this._i = AeccWatershedRegionFlat_object as Autodesk.AECC.Interop.Land.IAeccWatershedRegionFlat;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string DrainsInto => this._i.DrainsInto;
	}
}
