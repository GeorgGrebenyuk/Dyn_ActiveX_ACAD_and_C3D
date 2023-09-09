namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumSuperelevationStationRounding 
	{
		public AeccXLandLib.IAeccPropertyEnumSuperelevationStationRounding _i;
		internal AeccPropertyEnumSuperelevationStationRounding(object AeccPropertyEnumSuperelevationStationRounding_object) 
		{
			this._i = AeccPropertyEnumSuperelevationStationRounding_object as AeccXLandLib.IAeccPropertyEnumSuperelevationStationRounding;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccSuperelevationStationRoundingType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
