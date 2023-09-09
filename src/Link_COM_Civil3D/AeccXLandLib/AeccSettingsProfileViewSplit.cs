namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsProfileViewSplit 
	{
		public AeccXLandLib.IAeccSettingsProfileViewSplit _i;
		internal AeccSettingsProfileViewSplit(object AeccSettingsProfileViewSplit_object) 
		{
			this._i = AeccSettingsProfileViewSplit_object as AeccXLandLib.IAeccSettingsProfileViewSplit;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SplitProfileViews => this._i.SplitProfileViews;

		///<summary>
		///
		///</summary>
		public dynamic SplitStationOption => this._i.SplitStationOption;

		///<summary>
		///
		///</summary>
		public dynamic SplitDatumOption => this._i.SplitDatumOption;
	}
}
