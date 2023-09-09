namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSimplifySurface 
	{
		public AeccXLandLib.IAeccSettingsSimplifySurface _i;
		internal AeccSettingsSimplifySurface(object AeccSettingsSimplifySurface_object) 
		{
			this._i = AeccSettingsSimplifySurface_object as AeccXLandLib.IAeccSettingsSimplifySurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic RemoveByptsPercent => this._i.RemoveByptsPercent;

		///<summary>
		///
		///</summary>
		public dynamic RemoveptsPercent => this._i.RemoveptsPercent;

		///<summary>
		///
		///</summary>
		public dynamic UseMaxChaninElevation => this._i.UseMaxChaninElevation;

		///<summary>
		///
		///</summary>
		public dynamic ElevationChanMax => this._i.ElevationChanMax;

		///<summary>
		///
		///</summary>
		public dynamic SimplifyMethod => this._i.SimplifyMethod;

		///<summary>
		///
		///</summary>
		public dynamic RegionOptions => this._i.RegionOptions;
	}
}
