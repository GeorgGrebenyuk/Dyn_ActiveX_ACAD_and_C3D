namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateProfileFromSurface 
	{
		public AeccXLandLib.IAeccSettingsCreateProfileFromSurface _i;
		internal AeccSettingsCreateProfileFromSurface(object AeccSettingsCreateProfileFromSurface_object) 
		{
			this._i = AeccSettingsCreateProfileFromSurface_object as AeccXLandLib.IAeccSettingsCreateProfileFromSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ProfileSampleOffsetsCommandSettings => this._i.ProfileSampleOffsetsCommandSettings;
	}
}
