namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumStationDelimiterPosition 
	{
		public AeccXLandLib.IAeccPropertyEnumStationDelimiterPosition _i;
		internal AeccPropertyEnumStationDelimiterPosition(object AeccPropertyEnumStationDelimiterPosition_object) 
		{
			this._i = AeccPropertyEnumStationDelimiterPosition_object as AeccXLandLib.IAeccPropertyEnumStationDelimiterPosition;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccStationDelimiterPositionType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
