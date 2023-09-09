namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateAlignfromCorridor 
	{
		public AeccXRoadwayLib.IAeccSettingsCreateAlignfromCorridor _i;
		internal AeccSettingsCreateAlignfromCorridor(object AeccSettingsCreateAlignfromCorridor_object) 
		{
			this._i = AeccSettingsCreateAlignfromCorridor_object as AeccXRoadwayLib.IAeccSettingsCreateAlignfromCorridor;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreateProfileFromCorridor => this._i.CreateProfileFromCorridor;

		///<summary>
		///
		///</summary>
		public dynamic CriteriaBasedDesignOptions => this._i.CriteriaBasedDesignOptions;
	}
}
