namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionOffsetLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionOffsetLabelGroup _i;
		internal AeccSectionOffsetLabelGroup(object AeccSectionOffsetLabelGroup_object) 
		{
			this._i = AeccSectionOffsetLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccSectionOffsetLabelGroup;
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
