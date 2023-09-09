namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumSheetCreate 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumSheetCreate _i;
		internal AeccPropertyEnumSheetCreate(object AeccPropertyEnumSheetCreate_object) 
		{
			this._i = AeccPropertyEnumSheetCreate_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumSheetCreate;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccSheetCreateType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
