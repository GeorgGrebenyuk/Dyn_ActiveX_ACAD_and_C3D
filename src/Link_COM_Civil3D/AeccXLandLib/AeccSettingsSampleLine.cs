namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSampleLine 
	{
		public AeccXLandLib.IAeccSettingsSampleLine _i;
		internal AeccSettingsSampleLine(object AeccSettingsSampleLine_object) 
		{
			this._i = AeccSettingsSampleLine_object as AeccXLandLib.IAeccSettingsSampleLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic NameTemplate => this._i.NameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic GroupNameTemplate => this._i.GroupNameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic StyleSettings => this._i.StyleSettings;

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;

		///<summary>
		///
		///</summary>
		public dynamic LabelStyleDefaults => this._i.LabelStyleDefaults;
	}
}
