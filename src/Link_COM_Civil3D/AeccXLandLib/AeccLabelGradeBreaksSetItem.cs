namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelGradeBreaksSetItem 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelGradeBreaksSetItem _i;
		internal AeccLabelGradeBreaksSetItem(object AeccLabelGradeBreaksSetItem_object) 
		{
			this._i = AeccLabelGradeBreaksSetItem_object as Autodesk.AECC.Interop.Land.IAeccLabelGradeBreaksSetItem;
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
