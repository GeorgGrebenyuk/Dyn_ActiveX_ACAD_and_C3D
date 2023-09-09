namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelIncrementStyleSetItem 
	{
		public AeccXLandLib.IAeccLabelIncrementStyleSetItem _i;
		internal AeccLabelIncrementStyleSetItem(object AeccLabelIncrementStyleSetItem_object) 
		{
			this._i = AeccLabelIncrementStyleSetItem_object as AeccXLandLib.IAeccLabelIncrementStyleSetItem;
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
