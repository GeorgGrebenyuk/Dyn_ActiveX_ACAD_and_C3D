namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsConvertPointsToSdskPoints 
	{
		public AeccXLandLib.IAeccSettingsConvertPointsToSdskPoints _i;
		internal AeccSettingsConvertPointsToSdskPoints(object AeccSettingsConvertPointsToSdskPoints_object) 
		{
			this._i = AeccSettingsConvertPointsToSdskPoints_object as AeccXLandLib.IAeccSettingsConvertPointsToSdskPoints;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DefaultLayer => this._i.DefaultLayer;
	}
}
