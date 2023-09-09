namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelGradeBreaksStyleSetItem 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelGradeBreaksStyleSetItem _i;
		internal AeccLabelGradeBreaksStyleSetItem(object AeccLabelGradeBreaksStyleSetItem_object) 
		{
			this._i = AeccLabelGradeBreaksStyleSetItem_object as Autodesk.AECC.Interop.Land.IAeccLabelGradeBreaksStyleSetItem;
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
