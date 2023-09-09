namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumReportType 
	{
		public AeccXRoadwayLib.IAeccPropertyEnumReportType _i;
		internal AeccPropertyEnumReportType(object AeccPropertyEnumReportType_object) 
		{
			this._i = AeccPropertyEnumReportType_object as AeccXRoadwayLib.IAeccPropertyEnumReportType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXRoadwayLib.AeccReportType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
