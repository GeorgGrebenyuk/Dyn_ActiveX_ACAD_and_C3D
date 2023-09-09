namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateProfileFromSurface 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateProfileFromSurface _i;
		internal AeccSettingsCreateProfileFromSurface(object AeccSettingsCreateProfileFromSurface_object) 
		{
			this._i = AeccSettingsCreateProfileFromSurface_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateProfileFromSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ProfileSampleOffsetsCommandSettings => this._i.ProfileSampleOffsetsCommandSettings;
	}
}
