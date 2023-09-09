namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGradingGradeUnit 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsGradingGradeUnit _i;
		internal AeccSettingsGradingGradeUnit(object AeccSettingsGradingGradeUnit_object) 
		{
			this._i = AeccSettingsGradingGradeUnit_object as Autodesk.AECC.Interop.Land.IAeccSettingsGradingGradeUnit;
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
	}
}
