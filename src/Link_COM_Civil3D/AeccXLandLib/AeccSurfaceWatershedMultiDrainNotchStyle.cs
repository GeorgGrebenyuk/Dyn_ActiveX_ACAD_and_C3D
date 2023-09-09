namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedMultiDrainNotchStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedMultiDrainNotchStyle _i;
		internal AeccSurfaceWatershedMultiDrainNotchStyle(object AeccSurfaceWatershedMultiDrainNotchStyle_object) 
		{
			this._i = AeccSurfaceWatershedMultiDrainNotchStyle_object as Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedMultiDrainNotchStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
