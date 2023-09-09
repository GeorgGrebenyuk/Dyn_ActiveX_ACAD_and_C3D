namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsLatLong 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsLatLong _i;
		internal AeccSettingsLatLong(object AeccSettingsLatLong_object) 
		{
			this._i = AeccSettingsLatLong_object as Autodesk.AECC.Interop.Land.IAeccSettingsLatLong;
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
	}
}
