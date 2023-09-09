namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsBuildingSite 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsBuildingSite _i;
		internal AeccSettingsBuildingSite(object AeccSettingsBuildingSite_object) 
		{
			this._i = AeccSettingsBuildingSite_object as Autodesk.AECC.Interop.Land.IAeccSettingsBuildingSite;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
