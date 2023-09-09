namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyTextStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyTextStyle _i;
		internal AeccPropertyTextStyle(object AeccPropertyTextStyle_object) 
		{
			this._i = AeccPropertyTextStyle_object as Autodesk.AECC.Interop.Land.IAeccPropertyTextStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
