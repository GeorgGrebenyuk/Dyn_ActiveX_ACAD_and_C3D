namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSurfaceExtractObjects 
	{
		public AeccXLandLib.IAeccSettingsSurfaceExtractObjects _i;
		internal AeccSettingsSurfaceExtractObjects(object AeccSettingsSurfaceExtractObjects_object) 
		{
			this._i = AeccSettingsSurfaceExtractObjects_object as AeccXLandLib.IAeccSettingsSurfaceExtractObjects;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
