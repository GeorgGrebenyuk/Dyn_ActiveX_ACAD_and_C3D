namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccWatershedRegionBoundaryPoint 
	{
		public Autodesk.AECC.Interop.Land.IAeccWatershedRegionBoundaryPoint _i;
		internal AeccWatershedRegionBoundaryPoint(object AeccWatershedRegionBoundaryPoint_object) 
		{
			this._i = AeccWatershedRegionBoundaryPoint_object as Autodesk.AECC.Interop.Land.IAeccWatershedRegionBoundaryPoint;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object BoundaryDrainPoint => this._i.BoundaryDrainPoint;
	}
}
