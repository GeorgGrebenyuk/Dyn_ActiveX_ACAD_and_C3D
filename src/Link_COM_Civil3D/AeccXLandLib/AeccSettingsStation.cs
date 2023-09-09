namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsStation 
	{
		public AeccXLandLib.IAeccSettingsStation _i;
		internal AeccSettingsStation(object AeccSettingsStation_object) 
		{
			this._i = AeccSettingsStation_object as AeccXLandLib.IAeccSettingsStation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Unit => this._i.Unit;

		///<summary>
		///
		///</summary>
		public dynamic Format => this._i.Format;

		///<summary>
		///
		///</summary>
		public dynamic Precision => this._i.Precision;

		///<summary>
		///
		///</summary>
		public dynamic Rounding => this._i.Rounding;

		///<summary>
		///
		///</summary>
		public dynamic Sign => this._i.Sign;

		///<summary>
		///
		///</summary>
		public dynamic StationDelimiterCharacter => this._i.StationDelimiterCharacter;

		///<summary>
		///
		///</summary>
		public dynamic StationDelimiterPosition => this._i.StationDelimiterPosition;

		///<summary>
		///
		///</summary>
		public dynamic DropDecimalsForWholeNumbers => this._i.DropDecimalsForWholeNumbers;

		///<summary>
		///
		///</summary>
		public dynamic MinimumDisplayWidth => this._i.MinimumDisplayWidth;
	}
}
