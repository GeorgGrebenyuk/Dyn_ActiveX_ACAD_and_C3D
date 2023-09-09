namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsSectionView 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCommandsSectionView _i;
		internal AeccSettingsCommandsSectionView(object AeccSettingsCommandsSectionView_object) 
		{
			this._i = AeccSettingsCommandsSectionView_object as Autodesk.AECC.Interop.Land.IAeccSettingsCommandsSectionView;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AddSectionViewGradeLblSettings => this._i.AddSectionViewGradeLblSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddSectionViewOffElevLblSettings => this._i.AddSectionViewOffElevLblSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateMultipleSectionViewSettings => this._i.CreateMultipleSectionViewSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreateSectionViewSettings => this._i.CreateSectionViewSettings;
	}
}
