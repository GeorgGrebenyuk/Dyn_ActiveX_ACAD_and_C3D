namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyTextStyle 
	{
		public AeccXLandLib.IAeccPropertyTextStyle _i;
		internal AeccPropertyTextStyle(object AeccPropertyTextStyle_object) 
		{
			this._i = AeccPropertyTextStyle_object as AeccXLandLib.IAeccPropertyTextStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
