namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateSurfaceReference 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateSurfaceReference _i;
		internal AeccSettingsCreateSurfaceReference(object AeccSettingsCreateSurfaceReference_object) 
		{
			this._i = AeccSettingsCreateSurfaceReference_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateSurfaceReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
