namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateSiteParcels 
	{
		public AeccXLandLib.IAeccSettingsCreateSiteParcels _i;
		internal AeccSettingsCreateSiteParcels(object AeccSettingsCreateSiteParcels_object) 
		{
			this._i = AeccSettingsCreateSiteParcels_object as AeccXLandLib.IAeccSettingsCreateSiteParcels;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic NextAutomaticAreaCounter => this._i.NextAutomaticAreaCounter;

		///<summary>
		///
		///</summary>
		public dynamic NextManualAreaCounter => this._i.NextManualAreaCounter;

		///<summary>
		///
		///</summary>
		public dynamic LineNextAutomaticTagCounter => this._i.LineNextAutomaticTagCounter;

		///<summary>
		///
		///</summary>
		public dynamic LineNextManualTagCounter => this._i.LineNextManualTagCounter;

		///<summary>
		///
		///</summary>
		public dynamic CurveNextAutomaticTagCounter => this._i.CurveNextAutomaticTagCounter;

		///<summary>
		///
		///</summary>
		public dynamic CurveNextManualTagCounter => this._i.CurveNextManualTagCounter;
	}
}
