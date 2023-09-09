namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsDirection 
	{
		public AeccXLandLib.IAeccSettingsDirection _i;
		internal AeccSettingsDirection(object AeccSettingsDirection_object) 
		{
			this._i = AeccSettingsDirection_object as AeccXLandLib.IAeccSettingsDirection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Unit => this._i.Unit;

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
		public dynamic Format => this._i.Format;

		///<summary>
		///
		///</summary>
		public dynamic Direction => this._i.Direction;

		///<summary>
		///
		///</summary>
		public dynamic Capitalization => this._i.Capitalization;

		///<summary>
		///
		///</summary>
		public dynamic Sign => this._i.Sign;

		///<summary>
		///
		///</summary>
		public dynamic MeasurementType => this._i.MeasurementType;

		///<summary>
		///
		///</summary>
		public dynamic BearingQuadrant => this._i.BearingQuadrant;
	}
}
