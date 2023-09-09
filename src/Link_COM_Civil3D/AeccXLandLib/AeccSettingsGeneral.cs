namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGeneral 
	{
		public AeccXLandLib.IAeccSettingsGeneral _i;
		internal AeccSettingsGeneral(object AeccSettingsGeneral_object) 
		{
			this._i = AeccSettingsGeneral_object as AeccXLandLib.IAeccSettingsGeneral;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic PlottedTextDisplay => this._i.PlottedTextDisplay;

		///<summary>
		///
		///</summary>
		public dynamic DecimalCharacter => this._i.DecimalCharacter;

		///<summary>
		///
		///</summary>
		public dynamic SaveCommandChanges => this._i.SaveCommandChanges;

		///<summary>
		///
		///</summary>
		public dynamic ShowTooltips => this._i.ShowTooltips;

		///<summary>
		///
		///</summary>
		public dynamic ShowEventViewer => this._i.ShowEventViewer;

		///<summary>
		///
		///</summary>
		public dynamic NewEntityToolTipState => this._i.NewEntityToolTipState;

		///<summary>
		///
		///</summary>
		public dynamic IndependentLayerOn => this._i.IndependentLayerOn;
	}
}
