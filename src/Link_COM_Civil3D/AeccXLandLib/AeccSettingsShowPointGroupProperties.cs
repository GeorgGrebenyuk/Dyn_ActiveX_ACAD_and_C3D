namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsShowPointGroupProperties 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsShowPointGroupProperties _i;
		internal AeccSettingsShowPointGroupProperties(object AeccSettingsShowPointGroupProperties_object) 
		{
			this._i = AeccSettingsShowPointGroupProperties_object as Autodesk.AECC.Interop.Land.IAeccSettingsShowPointGroupProperties;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
