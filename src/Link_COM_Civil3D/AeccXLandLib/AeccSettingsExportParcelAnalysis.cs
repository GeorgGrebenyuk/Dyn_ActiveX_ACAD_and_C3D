namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsExportParcelAnalysis 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsExportParcelAnalysis _i;
		internal AeccSettingsExportParcelAnalysis(object AeccSettingsExportParcelAnalysis_object) 
		{
			this._i = AeccSettingsExportParcelAnalysis_object as Autodesk.AECC.Interop.Land.IAeccSettingsExportParcelAnalysis;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ParcelAnalysisSettings => this._i.ParcelAnalysisSettings;
	}
}
