namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumStationDelimiterPosition 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumStationDelimiterPosition _i;
		internal AeccPropertyEnumStationDelimiterPosition(object AeccPropertyEnumStationDelimiterPosition_object) 
		{
			this._i = AeccPropertyEnumStationDelimiterPosition_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumStationDelimiterPosition;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccStationDelimiterPositionType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
