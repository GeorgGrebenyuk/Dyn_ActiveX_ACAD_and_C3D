namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccWatershedRegionBoundarySegment 
	{
		public AeccXLandLib.IAeccWatershedRegionBoundarySegment _i;
		internal AeccWatershedRegionBoundarySegment(object AeccWatershedRegionBoundarySegment_object) 
		{
			this._i = AeccWatershedRegionBoundarySegment_object as AeccXLandLib.IAeccWatershedRegionBoundarySegment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object BoundaryDrainSegment => this._i.BoundaryDrainSegment;
	}
}
