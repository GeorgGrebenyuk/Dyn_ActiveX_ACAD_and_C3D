namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStationElevationLabel 
	{
		public AeccXLandLib.IAeccStationElevationLabel _i;
		internal AeccStationElevationLabel(object AeccStationElevationLabel_object) 
		{
			this._i = AeccStationElevationLabel_object as AeccXLandLib.IAeccStationElevationLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ProfileView => this._i.ProfileView;

		///<summary>
		///
		///</summary>
		public dynamic MarkerStyle => this._i.MarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_MarkerStyle(object ppVal) 
		{
			this._i.MarkerStyle = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic LeaderAttachmentOption => this._i.LeaderAttachmentOption;

		///<summary>
		///
		///</summary>
		public void Set_LeaderAttachmentOption(AeccXLandLib.AeccLabelLeaderAttachmentType pVal) 
		{
			this._i.LeaderAttachmentOption = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Profile1 => this._i.Profile1;

		///<summary>
		///
		///</summary>
		public void Set_Profile1(object ppVal) 
		{
			this._i.Profile1 = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Profile2 => this._i.Profile2;

		///<summary>
		///
		///</summary>
		public void Set_Profile2(object ppVal) 
		{
			this._i.Profile2 = ppVal;
		}
	}
}
