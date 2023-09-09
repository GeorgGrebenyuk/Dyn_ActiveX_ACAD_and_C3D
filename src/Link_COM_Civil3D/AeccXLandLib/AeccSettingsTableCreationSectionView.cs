namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsTableCreationSectionView 
	{
		public AeccXLandLib.IAeccSettingsTableCreationSectionView _i;
		internal AeccSettingsTableCreationSectionView(object AeccSettingsTableCreationSectionView_object) 
		{
			this._i = AeccSettingsTableCreationSectionView_object as AeccXLandLib.IAeccSettingsTableCreationSectionView;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CumulativeVolStyle => this._i.CumulativeVolStyle;

		///<summary>
		///
		///</summary>
		public dynamic MateralStyle => this._i.MateralStyle;

		///<summary>
		///
		///</summary>
		public dynamic OffsetX => this._i.OffsetX;

		///<summary>
		///
		///</summary>
		public dynamic OffsetY => this._i.OffsetY;
	}
}
