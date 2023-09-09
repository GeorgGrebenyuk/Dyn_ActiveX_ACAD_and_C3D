namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGenerateQuantitiesReport 
	{
		public AeccXRoadwayLib.IAeccSettingsGenerateQuantitiesReport _i;
		internal AeccSettingsGenerateQuantitiesReport(object AeccSettingsGenerateQuantitiesReport_object) 
		{
			this._i = AeccSettingsGenerateQuantitiesReport_object as AeccXRoadwayLib.IAeccSettingsGenerateQuantitiesReport;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayXMLReport => this._i.DisplayXMLReport;
	}
}
