namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelMinorStationStyleSetItem 
	{
		public AeccXLandLib.IAeccLabelMinorStationStyleSetItem _i;
		internal AeccLabelMinorStationStyleSetItem(object AeccLabelMinorStationStyleSetItem_object) 
		{
			this._i = AeccLabelMinorStationStyleSetItem_object as AeccXLandLib.IAeccLabelMinorStationStyleSetItem;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Parent => this._i.Parent;
	}
}
