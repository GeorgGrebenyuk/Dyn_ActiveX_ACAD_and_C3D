namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumProfileViewSplitStation 
	{
		public AeccXLandLib.IAeccPropertyEnumProfileViewSplitStation _i;
		internal AeccPropertyEnumProfileViewSplitStation(object AeccPropertyEnumProfileViewSplitStation_object) 
		{
			this._i = AeccPropertyEnumProfileViewSplitStation_object as AeccXLandLib.IAeccPropertyEnumProfileViewSplitStation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccProfileViewSplitStationType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
