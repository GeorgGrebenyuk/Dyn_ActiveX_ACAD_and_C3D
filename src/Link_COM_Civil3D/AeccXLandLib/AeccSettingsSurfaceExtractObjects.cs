namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSurfaceExtractObjects 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsSurfaceExtractObjects _i;
		internal AeccSettingsSurfaceExtractObjects(object AeccSettingsSurfaceExtractObjects_object) 
		{
			this._i = AeccSettingsSurfaceExtractObjects_object as Autodesk.AECC.Interop.Land.IAeccSettingsSurfaceExtractObjects;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
