namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumDecimalCharacter 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumDecimalCharacter _i;
		internal AeccPropertyEnumDecimalCharacter(object AeccPropertyEnumDecimalCharacter_object) 
		{
			this._i = AeccPropertyEnumDecimalCharacter_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumDecimalCharacter;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccDecimalCharacterType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
