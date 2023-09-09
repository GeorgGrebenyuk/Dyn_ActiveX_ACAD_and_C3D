namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsImportSurface 
	{
		public AeccXLandLib.IAeccSettingsImportSurface _i;
		internal AeccSettingsImportSurface(object AeccSettingsImportSurface_object) 
		{
			this._i = AeccSettingsImportSurface_object as AeccXLandLib.IAeccSettingsImportSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
