namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceElevationLabel 
	{
		public AeccXLandLib.IAeccSurfaceElevationLabel _i;
		internal AeccSurfaceElevationLabel(object AeccSurfaceElevationLabel_object) 
		{
			this._i = AeccSurfaceElevationLabel_object as AeccXLandLib.IAeccSurfaceElevationLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Surface => this._i.Surface;

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
	}
}
