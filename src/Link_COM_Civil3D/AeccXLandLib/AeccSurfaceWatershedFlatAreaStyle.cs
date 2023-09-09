namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedFlatAreaStyle 
	{
		public AeccXLandLib.IAeccSurfaceWatershedFlatAreaStyle _i;
		internal AeccSurfaceWatershedFlatAreaStyle(object AeccSurfaceWatershedFlatAreaStyle_object) 
		{
			this._i = AeccSurfaceWatershedFlatAreaStyle_object as AeccXLandLib.IAeccSurfaceWatershedFlatAreaStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
