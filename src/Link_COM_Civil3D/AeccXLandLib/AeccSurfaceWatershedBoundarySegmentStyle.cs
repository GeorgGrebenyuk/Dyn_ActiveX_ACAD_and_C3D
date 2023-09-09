namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedBoundarySegmentStyle 
	{
		public AeccXLandLib.IAeccSurfaceWatershedBoundarySegmentStyle _i;
		internal AeccSurfaceWatershedBoundarySegmentStyle(object AeccSurfaceWatershedBoundarySegmentStyle_object) 
		{
			this._i = AeccSurfaceWatershedBoundarySegmentStyle_object as AeccXLandLib.IAeccSurfaceWatershedBoundarySegmentStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
