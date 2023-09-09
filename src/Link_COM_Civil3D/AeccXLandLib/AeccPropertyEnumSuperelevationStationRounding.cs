namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumSuperelevationStationRounding 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumSuperelevationStationRounding _i;
		internal AeccPropertyEnumSuperelevationStationRounding(object AeccPropertyEnumSuperelevationStationRounding_object) 
		{
			this._i = AeccPropertyEnumSuperelevationStationRounding_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumSuperelevationStationRounding;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccSuperelevationStationRoundingType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
