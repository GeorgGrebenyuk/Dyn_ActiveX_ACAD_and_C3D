namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelMajorStationStyleSetItem 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelMajorStationStyleSetItem _i;
		internal AeccLabelMajorStationStyleSetItem(object AeccLabelMajorStationStyleSetItem_object) 
		{
			this._i = AeccLabelMajorStationStyleSetItem_object as Autodesk.AECC.Interop.Land.IAeccLabelMajorStationStyleSetItem;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
