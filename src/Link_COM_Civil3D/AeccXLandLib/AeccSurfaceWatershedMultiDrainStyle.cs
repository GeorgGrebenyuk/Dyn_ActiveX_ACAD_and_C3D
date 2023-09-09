namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedMultiDrainStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedMultiDrainStyle _i;
		internal AeccSurfaceWatershedMultiDrainStyle(object AeccSurfaceWatershedMultiDrainStyle_object) 
		{
			this._i = AeccSurfaceWatershedMultiDrainStyle_object as Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedMultiDrainStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
