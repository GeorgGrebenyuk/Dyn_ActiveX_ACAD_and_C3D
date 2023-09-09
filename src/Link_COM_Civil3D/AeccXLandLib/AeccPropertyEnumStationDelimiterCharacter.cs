namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumStationDelimiterCharacter 
	{
		public AeccXLandLib.IAeccPropertyEnumStationDelimiterCharacter _i;
		internal AeccPropertyEnumStationDelimiterCharacter(object AeccPropertyEnumStationDelimiterCharacter_object) 
		{
			this._i = AeccPropertyEnumStationDelimiterCharacter_object as AeccXLandLib.IAeccPropertyEnumStationDelimiterCharacter;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccStationDelimiterCharacterType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
