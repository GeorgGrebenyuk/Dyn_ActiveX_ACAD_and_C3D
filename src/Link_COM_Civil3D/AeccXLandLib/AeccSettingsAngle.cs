namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAngle 
	{
		public AeccXLandLib.IAeccSettingsAngle _i;
		internal AeccSettingsAngle(object AeccSettingsAngle_object) 
		{
			this._i = AeccSettingsAngle_object as AeccXLandLib.IAeccSettingsAngle;
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
		public dynamic Sign => this._i.Sign;
	}
}
