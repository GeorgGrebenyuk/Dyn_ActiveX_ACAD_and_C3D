namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsImportBuildingSite 
	{
		public AeccXLandLib.IAeccSettingsImportBuildingSite _i;
		internal AeccSettingsImportBuildingSite(object AeccSettingsImportBuildingSite_object) 
		{
			this._i = AeccSettingsImportBuildingSite_object as AeccXLandLib.IAeccSettingsImportBuildingSite;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
