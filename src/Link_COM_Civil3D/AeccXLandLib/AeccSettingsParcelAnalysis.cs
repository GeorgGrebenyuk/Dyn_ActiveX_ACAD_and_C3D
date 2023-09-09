namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsParcelAnalysis 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsParcelAnalysis _i;
		internal AeccSettingsParcelAnalysis(object AeccSettingsParcelAnalysis_object) 
		{
			this._i = AeccSettingsParcelAnalysis_object as Autodesk.AECC.Interop.Land.IAeccSettingsParcelAnalysis;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic EnableMapcheckAcrossChord => this._i.EnableMapcheckAcrossChord;

		///<summary>
		///
		///</summary>
		public dynamic ProcessCounterClockwise => this._i.ProcessCounterClockwise;

		///<summary>
		///
		///</summary>
		public dynamic AnalysisType => this._i.AnalysisType;
	}
}
