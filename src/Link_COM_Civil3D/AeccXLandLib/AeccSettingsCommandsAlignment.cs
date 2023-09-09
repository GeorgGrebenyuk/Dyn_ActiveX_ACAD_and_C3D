namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsAlignment 
	{
		public AeccXLandLib.IAeccSettingsCommandsAlignment _i;
		internal AeccSettingsCommandsAlignment(object AeccSettingsCommandsAlignment_object) 
		{
			this._i = AeccSettingsCommandsAlignment_object as AeccXLandLib.IAeccSettingsCommandsAlignment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AddAlignmentCurveTableSettings => this._i.AddAlignmentCurveTableSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddAlignmentLineTableSettings => this._i.AddAlignmentLineTableSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddAlignmentSegmentTableSettings => this._i.AddAlignmentSegmentTableSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddAlignmentSpiralTableSettings => this._i.AddAlignmentSpiralTableSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddAlignOffLblSettings => this._i.AddAlignOffLblSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddAlignOffXYLblSettings => this._i.AddAlignOffXYLblSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddAlignSegLblSettings => this._i.AddAlignSegLblSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddAlignSegLblsSettings => this._i.AddAlignSegLblsSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddAlignPointOfIntLblSettings => this._i.AddAlignPointOfIntLblSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddAlignPointOfIntLblsSettings => this._i.AddAlignPointOfIntLblsSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateAlignmentEntitiesSettings => this._i.CreateAlignmentEntitiesSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateAlignmentLayoutSettings => this._i.CreateAlignmentLayoutSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateAlignmentReferenceSettings => this._i.CreateAlignmentReferenceSettings;

		///<summary>
		///
		///</summary>
		public dynamic ReverseAlignmentDirectionSettings => this._i.ReverseAlignmentDirectionSettings;
	}
}
