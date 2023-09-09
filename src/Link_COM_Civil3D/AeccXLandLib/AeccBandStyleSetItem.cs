namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBandStyleSetItem 
	{
		public AeccXLandLib.IAeccBandStyleSetItem _i;
		internal AeccBandStyleSetItem(object AeccBandStyleSetItem_object) 
		{
			this._i = AeccBandStyleSetItem_object as AeccXLandLib.IAeccBandStyleSetItem;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
