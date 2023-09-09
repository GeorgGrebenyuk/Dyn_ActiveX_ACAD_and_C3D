namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsBuildingSite 
	{
		public AeccXLandLib.IAeccSettingsCommandsBuildingSite _i;
		internal AeccSettingsCommandsBuildingSite(object AeccSettingsCommandsBuildingSite_object) 
		{
			this._i = AeccSettingsCommandsBuildingSite_object as AeccXLandLib.IAeccSettingsCommandsBuildingSite;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ImportBuildingSite => this._i.ImportBuildingSite;
	}
}
