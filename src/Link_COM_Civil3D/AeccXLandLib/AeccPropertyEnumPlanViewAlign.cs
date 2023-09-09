namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumPlanViewAlign 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumPlanViewAlign _i;
		internal AeccPropertyEnumPlanViewAlign(object AeccPropertyEnumPlanViewAlign_object) 
		{
			this._i = AeccPropertyEnumPlanViewAlign_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumPlanViewAlign;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccPlanViewAlignType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
