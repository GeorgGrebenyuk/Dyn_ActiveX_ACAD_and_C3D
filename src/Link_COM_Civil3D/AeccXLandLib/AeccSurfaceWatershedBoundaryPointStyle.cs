namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedBoundaryPointStyle 
	{
		public AeccXLandLib.IAeccSurfaceWatershedBoundaryPointStyle _i;
		internal AeccSurfaceWatershedBoundaryPointStyle(object AeccSurfaceWatershedBoundaryPointStyle_object) 
		{
			this._i = AeccSurfaceWatershedBoundaryPointStyle_object as AeccXLandLib.IAeccSurfaceWatershedBoundaryPointStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
