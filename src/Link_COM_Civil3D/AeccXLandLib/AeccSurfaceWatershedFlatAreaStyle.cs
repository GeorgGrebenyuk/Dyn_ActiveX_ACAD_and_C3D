namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedFlatAreaStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedFlatAreaStyle _i;
		internal AeccSurfaceWatershedFlatAreaStyle(object AeccSurfaceWatershedFlatAreaStyle_object) 
		{
			this._i = AeccSurfaceWatershedFlatAreaStyle_object as Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedFlatAreaStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
