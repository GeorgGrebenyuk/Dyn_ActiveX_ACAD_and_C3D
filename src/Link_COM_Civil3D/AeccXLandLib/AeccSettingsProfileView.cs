namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsProfileView 
	{
		public AeccXLandLib.IAeccSettingsProfileView _i;
		internal AeccSettingsProfileView(object AeccSettingsProfileView_object) 
		{
			this._i = AeccSettingsProfileView_object as AeccXLandLib.IAeccSettingsProfileView;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic NameTemplate => this._i.NameTemplate;

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

		///<summary>
		///
		///</summary>
		public dynamic ProfileViewCreation => this._i.ProfileViewCreation;

		///<summary>
		///
		///</summary>
		public dynamic SplitProfileViewOptions => this._i.SplitProfileViewOptions;

		///<summary>
		///
		///</summary>
		public dynamic StackedProfileViewOptions => this._i.StackedProfileViewOptions;
	}
}
