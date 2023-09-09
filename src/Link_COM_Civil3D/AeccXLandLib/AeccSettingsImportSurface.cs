namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsImportSurface 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsImportSurface _i;
		internal AeccSettingsImportSurface(object AeccSettingsImportSurface_object) 
		{
			this._i = AeccSettingsImportSurface_object as Autodesk.AECC.Interop.Land.IAeccSettingsImportSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
