namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumStationFormat 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumStationFormat _i;
		internal AeccPropertyEnumStationFormat(object AeccPropertyEnumStationFormat_object) 
		{
			this._i = AeccPropertyEnumStationFormat_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumStationFormat;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccStationFormatType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
