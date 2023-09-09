namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsProfile 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsProfile _i;
		internal AeccSettingsProfile(object AeccSettingsProfile_object) 
		{
			this._i = AeccSettingsProfile_object as Autodesk.AECC.Interop.Land.IAeccSettingsProfile;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic NameTemplate => this._i.NameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic OffsetNameTemplate => this._i.OffsetNameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic SuperimposedProfileNameTemplate => this._i.SuperimposedProfileNameTemplate;

		///<summary>
		///
		///</summary>
		public dynamic ThreeDEntityProfileNameTemplate => this._i.ThreeDEntityProfileNameTemplate;

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
		public dynamic CreationSettings => this._i.CreationSettings;
	}
}
