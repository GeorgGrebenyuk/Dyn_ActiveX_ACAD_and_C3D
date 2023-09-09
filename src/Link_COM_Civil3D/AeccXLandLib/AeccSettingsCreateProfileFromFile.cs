namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateProfileFromFile 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateProfileFromFile _i;
		internal AeccSettingsCreateProfileFromFile(object AeccSettingsCreateProfileFromFile_object) 
		{
			this._i = AeccSettingsCreateProfileFromFile_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateProfileFromFile;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
