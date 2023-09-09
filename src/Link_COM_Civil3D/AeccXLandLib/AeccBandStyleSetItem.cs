namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBandStyleSetItem 
	{
		public Autodesk.AECC.Interop.Land.IAeccBandStyleSetItem _i;
		internal AeccBandStyleSetItem(object AeccBandStyleSetItem_object) 
		{
			this._i = AeccBandStyleSetItem_object as Autodesk.AECC.Interop.Land.IAeccBandStyleSetItem;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
