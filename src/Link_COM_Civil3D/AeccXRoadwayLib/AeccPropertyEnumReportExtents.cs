namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumReportExtents 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccPropertyEnumReportExtents _i;
		internal AeccPropertyEnumReportExtents(object AeccPropertyEnumReportExtents_object) 
		{
			this._i = AeccPropertyEnumReportExtents_object as Autodesk.AECC.Interop.Roadway.IAeccPropertyEnumReportExtents;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Roadway.AeccReportExtentsType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
