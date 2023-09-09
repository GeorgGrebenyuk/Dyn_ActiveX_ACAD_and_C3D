namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumSheetSet 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumSheetSet _i;
		internal AeccPropertyEnumSheetSet(object AeccPropertyEnumSheetSet_object) 
		{
			this._i = AeccPropertyEnumSheetSet_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumSheetSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccSheetSetType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
