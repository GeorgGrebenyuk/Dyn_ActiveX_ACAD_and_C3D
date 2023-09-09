namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateSurface 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateSurface _i;
		internal AeccSettingsCreateSurface(object AeccSettingsCreateSurface_object) 
		{
			this._i = AeccSettingsCreateSurface_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreationSurfaceSettings => this._i.CreationSurfaceSettings;

		///<summary>
		///
		///</summary>
		public dynamic BuildOptionsSettings => this._i.BuildOptionsSettings;
	}
}
