namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsProfileView 
	{
		public AeccXLandLib.IAeccSettingsCommandsProfileView _i;
		internal AeccSettingsCommandsProfileView(object AeccSettingsCommandsProfileView_object) 
		{
			this._i = AeccSettingsCommandsProfileView_object as AeccXLandLib.IAeccSettingsCommandsProfileView;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AddProfileViewDepthLblSettings => this._i.AddProfileViewDepthLblSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddProfileViewStaElevLblSettings => this._i.AddProfileViewStaElevLblSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateMultiProfileViewSettings => this._i.CreateMultiProfileViewSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateProfileViewSettings => this._i.CreateProfileViewSettings;
	}
}
