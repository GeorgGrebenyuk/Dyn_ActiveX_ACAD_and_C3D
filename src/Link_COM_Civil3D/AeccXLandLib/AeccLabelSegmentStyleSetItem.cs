namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelSegmentStyleSetItem 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelSegmentStyleSetItem _i;
		internal AeccLabelSegmentStyleSetItem(object AeccLabelSegmentStyleSetItem_object) 
		{
			this._i = AeccLabelSegmentStyleSetItem_object as Autodesk.AECC.Interop.Land.IAeccLabelSegmentStyleSetItem;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double WeedingFactor => this._i.WeedingFactor;

		///<summary>
		///
		///</summary>
		public void Set_WeedingFactor(double pVal) 
		{
			this._i.WeedingFactor = pVal;
		}
	}
}
