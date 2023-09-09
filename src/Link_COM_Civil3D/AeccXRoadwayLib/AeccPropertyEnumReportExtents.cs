namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumReportExtents 
	{
		public AeccXRoadwayLib.IAeccPropertyEnumReportExtents _i;
		internal AeccPropertyEnumReportExtents(object AeccPropertyEnumReportExtents_object) 
		{
			this._i = AeccPropertyEnumReportExtents_object as AeccXRoadwayLib.IAeccPropertyEnumReportExtents;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXRoadwayLib.AeccReportExtentsType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
