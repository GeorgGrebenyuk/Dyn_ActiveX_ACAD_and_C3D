namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsDrawing 
	{
		public AeccXLandLib.IAeccSettingsDrawing _i;
		internal AeccSettingsDrawing(object AeccSettingsDrawing_object) 
		{
			this._i = AeccSettingsDrawing_object as AeccXLandLib.IAeccSettingsDrawing;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic UnitZoneSettings => this._i.UnitZoneSettings;

		///<summary>
		///
		///</summary>
		public dynamic TransformationSettings => this._i.TransformationSettings;

		///<summary>
		///
		///</summary>
		public dynamic ObjectLayerSettings => this._i.ObjectLayerSettings;

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;

		///<summary>
		///
		///</summary>
		public dynamic AbbreviationSettings => this._i.AbbreviationSettings;

		///<summary>
		///
		///</summary>
		public dynamic LabelStyleDefaults => this._i.LabelStyleDefaults;
	}
}
