namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsGeneral 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCommandsGeneral _i;
		internal AeccSettingsCommandsGeneral(object AeccSettingsCommandsGeneral_object) 
		{
			this._i = AeccSettingsCommandsGeneral_object as Autodesk.AECC.Interop.Land.IAeccSettingsCommandsGeneral;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AddNoteLabelSettings => this._i.AddNoteLabelSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddSegmentLabelSettings => this._i.AddSegmentLabelSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddSegmentLabelsSettings => this._i.AddSegmentLabelsSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateArcByBestFitSettings => this._i.CreateArcByBestFitSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateLineByBestFitSettings => this._i.CreateLineByBestFitSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateParabolaByBestFitSettings => this._i.CreateParabolaByBestFitSettings;

		///<summary>
		///
		///</summary>
		public dynamic MapCheckSettings => this._i.MapCheckSettings;
	}
}
