namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsRoot 
	{
		public AeccXLandLib.IAeccSettingsRoot _i;
		internal AeccSettingsRoot(object AeccSettingsRoot_object) 
		{
			this._i = AeccSettingsRoot_object as AeccXLandLib.IAeccSettingsRoot;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DrawingSettings => this._i.DrawingSettings;

		///<summary>
		///
		///</summary>
		public dynamic GeneralSettings => this._i.GeneralSettings;

		///<summary>
		///
		///</summary>
		public dynamic PointSettings => this._i.PointSettings;

		///<summary>
		///
		///</summary>
		public dynamic PointCommandsSettings => this._i.PointCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic SurfaceSettings => this._i.SurfaceSettings;

		///<summary>
		///
		///</summary>
		public dynamic SurfaceCommandsSettings => this._i.SurfaceCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic ParcelSettings => this._i.ParcelSettings;

		///<summary>
		///
		///</summary>
		public dynamic ParcelCommandsSettings => this._i.ParcelCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic GradingSettings => this._i.GradingSettings;

		///<summary>
		///
		///</summary>
		public dynamic GradingCommandsSettings => this._i.GradingCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic AlignmentSettings => this._i.AlignmentSettings;

		///<summary>
		///
		///</summary>
		public dynamic AlignmentCommandsSettings => this._i.AlignmentCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic GeneralCommandsSettings => this._i.GeneralCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic ProfileSettings => this._i.ProfileSettings;

		///<summary>
		///
		///</summary>
		public dynamic ProfileCommandsSettings => this._i.ProfileCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic ProfileViewSettings => this._i.ProfileViewSettings;

		///<summary>
		///
		///</summary>
		public dynamic ProfileViewCommandsSettings => this._i.ProfileViewCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic SampleLineSettings => this._i.SampleLineSettings;

		///<summary>
		///
		///</summary>
		public dynamic SampleLineCommandsSettings => this._i.SampleLineCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic SectionSettings => this._i.SectionSettings;

		///<summary>
		///
		///</summary>
		public dynamic SectionViewSettings => this._i.SectionViewSettings;

		///<summary>
		///
		///</summary>
		public dynamic SectionViewCommandsSettings => this._i.SectionViewCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic MassHaulLineSettings => this._i.MassHaulLineSettings;

		///<summary>
		///
		///</summary>
		public dynamic MassHaulViewSettings => this._i.MassHaulViewSettings;

		///<summary>
		///
		///</summary>
		public dynamic MassHaulViewCommandsSettings => this._i.MassHaulViewCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic ViewFrameGroupSettings => this._i.ViewFrameGroupSettings;

		///<summary>
		///
		///</summary>
		public dynamic ViewFrameGroupCommandsSettings => this._i.ViewFrameGroupCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic ViewFrameSettings => this._i.ViewFrameSettings;

		///<summary>
		///
		///</summary>
		public dynamic MatchLineSettings => this._i.MatchLineSettings;

		///<summary>
		///
		///</summary>
		public dynamic BuildingSiteCommandsSettings => this._i.BuildingSiteCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic IntersectionCommandsSettings => this._i.IntersectionCommandsSettings;

		///<summary>
		///
		///</summary>
		public dynamic BuildingSiteSettings => this._i.BuildingSiteSettings;

		///<summary>
		///
		///</summary>
		public dynamic IntersectionSettings => this._i.IntersectionSettings;
	}
}
