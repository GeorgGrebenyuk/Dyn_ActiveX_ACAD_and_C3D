namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedBoundarySegmentStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedBoundarySegmentStyle _i;
		internal AeccSurfaceWatershedBoundarySegmentStyle(object AeccSurfaceWatershedBoundarySegmentStyle_object) 
		{
			this._i = AeccSurfaceWatershedBoundarySegmentStyle_object as Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedBoundarySegmentStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
