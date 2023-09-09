namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsViewEditCorridorSection 
	{
		public AeccXRoadwayLib.IAeccSettingsViewEditCorridorSection _i;
		internal AeccSettingsViewEditCorridorSection(object AeccSettingsViewEditCorridorSection_object) 
		{
			this._i = AeccSettingsViewEditCorridorSection_object as AeccXRoadwayLib.IAeccSettingsViewEditCorridorSection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ViewEditOptions => this._i.ViewEditOptions;

		///<summary>
		///
		///</summary>
		public dynamic GridSettings => this._i.GridSettings;

		///<summary>
		///
		///</summary>
		public dynamic GridTextSettings => this._i.GridTextSettings;
	}
}
