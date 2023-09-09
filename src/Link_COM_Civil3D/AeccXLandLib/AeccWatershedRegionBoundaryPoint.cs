namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccWatershedRegionBoundaryPoint 
	{
		public AeccXLandLib.IAeccWatershedRegionBoundaryPoint _i;
		internal AeccWatershedRegionBoundaryPoint(object AeccWatershedRegionBoundaryPoint_object) 
		{
			this._i = AeccWatershedRegionBoundaryPoint_object as AeccXLandLib.IAeccWatershedRegionBoundaryPoint;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object BoundaryDrainPoint => this._i.BoundaryDrainPoint;
	}
}
