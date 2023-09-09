namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumSheetCreate 
	{
		public AeccXLandLib.IAeccPropertyEnumSheetCreate _i;
		internal AeccPropertyEnumSheetCreate(object AeccPropertyEnumSheetCreate_object) 
		{
			this._i = AeccPropertyEnumSheetCreate_object as AeccXLandLib.IAeccPropertyEnumSheetCreate;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccSheetCreateType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
