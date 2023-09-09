namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumPlanViewAlign 
	{
		public AeccXLandLib.IAeccPropertyEnumPlanViewAlign _i;
		internal AeccPropertyEnumPlanViewAlign(object AeccPropertyEnumPlanViewAlign_object) 
		{
			this._i = AeccPropertyEnumPlanViewAlign_object as AeccXLandLib.IAeccPropertyEnumPlanViewAlign;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccPlanViewAlignType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
