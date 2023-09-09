namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedMultiDrainStyle 
	{
		public AeccXLandLib.IAeccSurfaceWatershedMultiDrainStyle _i;
		internal AeccSurfaceWatershedMultiDrainStyle(object AeccSurfaceWatershedMultiDrainStyle_object) 
		{
			this._i = AeccSurfaceWatershedMultiDrainStyle_object as AeccXLandLib.IAeccSurfaceWatershedMultiDrainStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
