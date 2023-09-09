namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsConvertPointsToSdskPoints 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsConvertPointsToSdskPoints _i;
		internal AeccSettingsConvertPointsToSdskPoints(object AeccSettingsConvertPointsToSdskPoints_object) 
		{
			this._i = AeccSettingsConvertPointsToSdskPoints_object as Autodesk.AECC.Interop.Land.IAeccSettingsConvertPointsToSdskPoints;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DefaultLayer => this._i.DefaultLayer;
	}
}
