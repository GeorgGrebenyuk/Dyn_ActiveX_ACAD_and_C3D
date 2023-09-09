namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateSiteAlignment 
	{
		public AeccXLandLib.IAeccSettingsCreateSiteAlignment _i;
		internal AeccSettingsCreateSiteAlignment(object AeccSettingsCreateSiteAlignment_object) 
		{
			this._i = AeccSettingsCreateSiteAlignment_object as AeccXLandLib.IAeccSettingsCreateSiteAlignment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SpiralNextManualTagCounter => this._i.SpiralNextManualTagCounter;

		///<summary>
		///
		///</summary>
		public dynamic SpiralNextAutomaticTagCounter => this._i.SpiralNextAutomaticTagCounter;

		///<summary>
		///
		///</summary>
		public dynamic CurveNextManualTagCounter => this._i.CurveNextManualTagCounter;

		///<summary>
		///
		///</summary>
		public dynamic CurveNextAutomaticTagCounter => this._i.CurveNextAutomaticTagCounter;

		///<summary>
		///
		///</summary>
		public dynamic LineNextManualTagCounter => this._i.LineNextManualTagCounter;

		///<summary>
		///
		///</summary>
		public dynamic LineNextAutomaticTagCounter => this._i.LineNextAutomaticTagCounter;
	}
}
