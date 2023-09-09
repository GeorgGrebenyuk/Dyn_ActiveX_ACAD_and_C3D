namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumReportType 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccPropertyEnumReportType _i;
		internal AeccPropertyEnumReportType(object AeccPropertyEnumReportType_object) 
		{
			this._i = AeccPropertyEnumReportType_object as Autodesk.AECC.Interop.Roadway.IAeccPropertyEnumReportType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Roadway.AeccReportType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
