namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGradeSlope 
	{
		public AeccXLandLib.IAeccSettingsGradeSlope _i;
		internal AeccSettingsGradeSlope(object AeccSettingsGradeSlope_object) 
		{
			this._i = AeccSettingsGradeSlope_object as AeccXLandLib.IAeccSettingsGradeSlope;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

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
