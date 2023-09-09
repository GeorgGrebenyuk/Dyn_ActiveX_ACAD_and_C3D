namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelMajorStationStyleSetItem 
	{
		public AeccXLandLib.IAeccLabelMajorStationStyleSetItem _i;
		internal AeccLabelMajorStationStyleSetItem(object AeccLabelMajorStationStyleSetItem_object) 
		{
			this._i = AeccLabelMajorStationStyleSetItem_object as AeccXLandLib.IAeccLabelMajorStationStyleSetItem;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
