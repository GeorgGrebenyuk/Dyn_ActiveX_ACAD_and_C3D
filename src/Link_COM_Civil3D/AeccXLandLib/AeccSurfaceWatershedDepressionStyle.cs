namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedDepressionStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedDepressionStyle _i;
		internal AeccSurfaceWatershedDepressionStyle(object AeccSurfaceWatershedDepressionStyle_object) 
		{
			this._i = AeccSurfaceWatershedDepressionStyle_object as Autodesk.AECC.Interop.Land.IAeccSurfaceWatershedDepressionStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
