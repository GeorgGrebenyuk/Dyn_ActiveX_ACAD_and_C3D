namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSectionTypeSettings2 
	{
		public AXDBLib.IAcadSectionTypeSettings2 _i;
		internal AcadSectionTypeSettings2(object AcadSectionTypeSettings2_object) 
		{
			this._i = AcadSectionTypeSettings2_object as AXDBLib.IAcadSectionTypeSettings2;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool IntersectionBoundaryVisible => this._i.IntersectionBoundaryVisible;

		///<summary>
		///
		///</summary>
		public void Set_IntersectionBoundaryVisible(bool pVal) 
		{
			this._i.IntersectionBoundaryVisible = pVal;
		}
	}
}
