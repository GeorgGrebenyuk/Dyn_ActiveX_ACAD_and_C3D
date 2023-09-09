namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccWatershedRegionBoundarySegment 
	{
		public Autodesk.AECC.Interop.Land.IAeccWatershedRegionBoundarySegment _i;
		internal AeccWatershedRegionBoundarySegment(object AeccWatershedRegionBoundarySegment_object) 
		{
			this._i = AeccWatershedRegionBoundarySegment_object as Autodesk.AECC.Interop.Land.IAeccWatershedRegionBoundarySegment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object BoundaryDrainSegment => this._i.BoundaryDrainSegment;
	}
}
