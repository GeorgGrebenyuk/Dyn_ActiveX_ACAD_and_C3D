namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSectionView 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsSectionView _i;
		internal AeccSettingsSectionView(object AeccSettingsSectionView_object) 
		{
			this._i = AeccSettingsSectionView_object as Autodesk.AECC.Interop.Land.IAeccSettingsSectionView;
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
	}
}
