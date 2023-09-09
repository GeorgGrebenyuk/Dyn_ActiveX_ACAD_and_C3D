namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAlignment 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAlignment _i;
		internal AeccSettingsAlignment(object AeccSettingsAlignment_object) 
		{
			this._i = AeccSettingsAlignment_object as Autodesk.AECC.Interop.Land.IAeccSettingsAlignment;
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

		///<summary>
		///
		///</summary>
		public dynamic StationIndexingSettings => this._i.StationIndexingSettings;

		///<summary>
		///
		///</summary>
		public dynamic SuperElevationOptionsSettings => this._i.SuperElevationOptionsSettings;
	}
}
