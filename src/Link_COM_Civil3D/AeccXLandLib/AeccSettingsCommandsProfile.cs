namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsProfile 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCommandsProfile _i;
		internal AeccSettingsCommandsProfile(object AeccSettingsCommandsProfile_object) 
		{
			this._i = AeccSettingsCommandsProfile_object as Autodesk.AECC.Interop.Land.IAeccSettingsCommandsProfile;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreateProfileFromFileSettings => this._i.CreateProfileFromFileSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateProfileFromSurfaceSettings => this._i.CreateProfileFromSurfaceSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateProfileLayoutSettings => this._i.CreateProfileLayoutSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateProfileReferenceSettings => this._i.CreateProfileReferenceSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateQuickProfileSettings => this._i.CreateQuickProfileSettings;

		///<summary>
		///
		///</summary>
		public dynamic SuperimposeProfileSettings => this._i.SuperimposeProfileSettings;
	}
}
