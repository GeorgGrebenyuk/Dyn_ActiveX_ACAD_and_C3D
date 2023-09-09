namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddAlignSegLbls 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAddAlignSegLbls _i;
		internal AeccSettingsAddAlignSegLbls(object AeccSettingsAddAlignSegLbls_object) 
		{
			this._i = AeccSettingsAddAlignSegLbls_object as Autodesk.AECC.Interop.Land.IAeccSettingsAddAlignSegLbls;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
