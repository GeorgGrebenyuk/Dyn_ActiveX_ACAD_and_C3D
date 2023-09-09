namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelGradeBreaksStyleSetItem 
	{
		public AeccXLandLib.IAeccLabelGradeBreaksStyleSetItem _i;
		internal AeccLabelGradeBreaksStyleSetItem(object AeccLabelGradeBreaksStyleSetItem_object) 
		{
			this._i = AeccLabelGradeBreaksStyleSetItem_object as AeccXLandLib.IAeccLabelGradeBreaksStyleSetItem;
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
