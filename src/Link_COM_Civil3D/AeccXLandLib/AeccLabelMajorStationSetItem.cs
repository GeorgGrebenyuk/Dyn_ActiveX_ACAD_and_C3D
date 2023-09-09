namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelMajorStationSetItem 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelMajorStationSetItem _i;
		internal AeccLabelMajorStationSetItem(object AeccLabelMajorStationSetItem_object) 
		{
			this._i = AeccLabelMajorStationSetItem_object as Autodesk.AECC.Interop.Land.IAeccLabelMajorStationSetItem;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double Increment => this._i.Increment;

		///<summary>
		///
		///</summary>
		public void Set_Increment(double pVal) 
		{
			this._i.Increment = pVal;
		}
	}
}
