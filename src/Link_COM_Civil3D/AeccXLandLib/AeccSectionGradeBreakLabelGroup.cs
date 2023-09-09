namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionGradeBreakLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionGradeBreakLabelGroup _i;
		internal AeccSectionGradeBreakLabelGroup(object AeccSectionGradeBreakLabelGroup_object) 
		{
			this._i = AeccSectionGradeBreakLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccSectionGradeBreakLabelGroup;
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
