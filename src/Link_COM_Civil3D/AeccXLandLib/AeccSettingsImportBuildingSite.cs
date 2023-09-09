namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsImportBuildingSite 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsImportBuildingSite _i;
		internal AeccSettingsImportBuildingSite(object AeccSettingsImportBuildingSite_object) 
		{
			this._i = AeccSettingsImportBuildingSite_object as Autodesk.AECC.Interop.Land.IAeccSettingsImportBuildingSite;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
