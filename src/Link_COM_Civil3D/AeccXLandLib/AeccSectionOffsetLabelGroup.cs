namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionOffsetLabelGroup 
	{
		public AeccXLandLib.IAeccSectionOffsetLabelGroup _i;
		internal AeccSectionOffsetLabelGroup(object AeccSectionOffsetLabelGroup_object) 
		{
			this._i = AeccSectionOffsetLabelGroup_object as AeccXLandLib.IAeccSectionOffsetLabelGroup;
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
