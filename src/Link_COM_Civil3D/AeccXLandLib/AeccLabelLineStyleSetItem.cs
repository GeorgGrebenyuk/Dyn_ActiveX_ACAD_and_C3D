namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelLineStyleSetItem 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelLineStyleSetItem _i;
		internal AeccLabelLineStyleSetItem(object AeccLabelLineStyleSetItem_object) 
		{
			this._i = AeccLabelLineStyleSetItem_object as Autodesk.AECC.Interop.Land.IAeccLabelLineStyleSetItem;
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
