namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumSheetSet 
	{
		public AeccXLandLib.IAeccPropertyEnumSheetSet _i;
		internal AeccPropertyEnumSheetSet(object AeccPropertyEnumSheetSet_object) 
		{
			this._i = AeccPropertyEnumSheetSet_object as AeccXLandLib.IAeccPropertyEnumSheetSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccSheetSetType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
