namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionGradeBreakLabelGroup 
	{
		public AeccXLandLib.IAeccSectionGradeBreakLabelGroup _i;
		internal AeccSectionGradeBreakLabelGroup(object AeccSectionGradeBreakLabelGroup_object) 
		{
			this._i = AeccSectionGradeBreakLabelGroup_object as AeccXLandLib.IAeccSectionGradeBreakLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double WeedingValue => this._i.WeedingValue;

		///<summary>
		///
		///</summary>
		public void Set_WeedingValue(double pVal) 
		{
			this._i.WeedingValue = pVal;
		}
	}
}
