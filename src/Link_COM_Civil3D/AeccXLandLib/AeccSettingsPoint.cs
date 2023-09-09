namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsPoint 
	{
		public AeccXLandLib.IAeccSettingsPoint _i;
		internal AeccSettingsPoint(object AeccSettingsPoint_object) 
		{
			this._i = AeccSettingsPoint_object as AeccXLandLib.IAeccSettingsPoint;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;

		///<summary>
		///
		///</summary>
		public dynamic LabelStyleDefaults => this._i.LabelStyleDefaults;

		///<summary>
		///
		///</summary>
		public dynamic StyleSettings => this._i.StyleSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreationSettings => this._i.CreationSettings;

		///<summary>
		///
		///</summary>
		public dynamic UpdateSettings => this._i.UpdateSettings;

		///<summary>
		///
		///</summary>
		public dynamic ImportSettings => this._i.ImportSettings;

		///<summary>
		///
		///</summary>
		public dynamic NameTemplate => this._i.NameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic GroupNameTemplate => this._i.GroupNameTemplate;
	}
}
