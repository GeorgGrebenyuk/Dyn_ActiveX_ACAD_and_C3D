namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGridTextSettings 
	{
		public AeccXRoadwayLib.IAeccSettingsGridTextSettings _i;
		internal AeccSettingsGridTextSettings(object AeccSettingsGridTextSettings_object) 
		{
			this._i = AeccSettingsGridTextSettings_object as AeccXRoadwayLib.IAeccSettingsGridTextSettings;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TextStyle => this._i.TextStyle;

		///<summary>
		///
		///</summary>
		public dynamic TextColor => this._i.TextColor;

		///<summary>
		///
		///</summary>
		public dynamic TextHeight => this._i.TextHeight;

		///<summary>
		///
		///</summary>
		public dynamic AnnotateCenterAxis => this._i.AnnotateCenterAxis;
	}
}
