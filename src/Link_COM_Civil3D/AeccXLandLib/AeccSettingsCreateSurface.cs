namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateSurface 
	{
		public AeccXLandLib.IAeccSettingsCreateSurface _i;
		internal AeccSettingsCreateSurface(object AeccSettingsCreateSurface_object) 
		{
			this._i = AeccSettingsCreateSurface_object as AeccXLandLib.IAeccSettingsCreateSurface;
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
