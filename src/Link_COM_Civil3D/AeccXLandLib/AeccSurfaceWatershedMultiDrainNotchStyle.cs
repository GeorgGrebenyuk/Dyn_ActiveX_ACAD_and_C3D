namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedMultiDrainNotchStyle 
	{
		public AeccXLandLib.IAeccSurfaceWatershedMultiDrainNotchStyle _i;
		internal AeccSurfaceWatershedMultiDrainNotchStyle(object AeccSurfaceWatershedMultiDrainNotchStyle_object) 
		{
			this._i = AeccSurfaceWatershedMultiDrainNotchStyle_object as AeccXLandLib.IAeccSurfaceWatershedMultiDrainNotchStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
