namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedBoundaryPointStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedBoundaryPointStyle _i;
		internal AeccSurfaceWatershedBoundaryPointStyle(object AeccSurfaceWatershedBoundaryPointStyle_object) 
		{
			this._i = AeccSurfaceWatershedBoundaryPointStyle_object as Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedBoundaryPointStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
