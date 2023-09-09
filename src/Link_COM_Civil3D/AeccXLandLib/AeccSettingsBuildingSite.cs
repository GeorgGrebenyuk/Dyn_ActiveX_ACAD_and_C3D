namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsBuildingSite 
	{
		public AeccXLandLib.IAeccSettingsBuildingSite _i;
		internal AeccSettingsBuildingSite(object AeccSettingsBuildingSite_object) 
		{
			this._i = AeccSettingsBuildingSite_object as AeccXLandLib.IAeccSettingsBuildingSite;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
