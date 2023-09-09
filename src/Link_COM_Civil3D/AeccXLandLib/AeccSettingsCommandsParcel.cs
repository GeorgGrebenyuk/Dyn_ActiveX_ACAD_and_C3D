namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsParcel 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCommandsParcel _i;
		internal AeccSettingsCommandsParcel(object AeccSettingsCommandsParcel_object) 
		{
			this._i = AeccSettingsCommandsParcel_object as Autodesk.AECC.Interop.Land.IAeccSettingsCommandsParcel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AddParcelAreaLabelSettings => this._i.AddParcelAreaLabelSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddParcelCurveTableSettings => this._i.AddParcelCurveTableSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddParcelLineTableSettings => this._i.AddParcelLineTableSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddParcelLineLabelSettings => this._i.AddParcelLineLabelSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddParcelSegmentLabelsSettings => this._i.AddParcelSegmentLabelsSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddParcelSegmentTableSettings => this._i.AddParcelSegmentTableSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddParcelTableSettings => this._i.AddParcelTableSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateParcelByLayoutSettings => this._i.CreateParcelByLayoutSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateParcelFromObjectsSettings => this._i.CreateParcelFromObjectsSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateParcelROWSettings => this._i.CreateParcelROWSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateSiteSettings => this._i.CreateSiteSettings;

		///<summary>
		///
		///</summary>
		public dynamic ExportParcelAnalysisSettings => this._i.ExportParcelAnalysisSettings;

		///<summary>
		///
		///</summary>
		public dynamic ReAddParcelAreaLabelSettings => this._i.ReAddParcelAreaLabelSettings;

		///<summary>
		///
		///</summary>
		public dynamic ReAddParcelSegmentLabelsSettings => this._i.ReAddParcelSegmentLabelsSettings;
	}
}
