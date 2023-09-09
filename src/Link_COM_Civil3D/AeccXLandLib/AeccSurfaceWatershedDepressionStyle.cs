namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedDepressionStyle 
	{
		public AeccXLandLib.IAeccSurfaceWatershedDepressionStyle _i;
		internal AeccSurfaceWatershedDepressionStyle(object AeccSurfaceWatershedDepressionStyle_object) 
		{
			this._i = AeccSurfaceWatershedDepressionStyle_object as AeccXLandLib.IAeccSurfaceWatershedDepressionStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
