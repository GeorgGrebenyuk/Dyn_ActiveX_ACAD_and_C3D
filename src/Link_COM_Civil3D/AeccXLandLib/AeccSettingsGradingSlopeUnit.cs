namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGradingSlopeUnit 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsGradingSlopeUnit _i;
		internal AeccSettingsGradingSlopeUnit(object AeccSettingsGradingSlopeUnit_object) 
		{
			this._i = AeccSettingsGradingSlopeUnit_object as Autodesk.AECC.Interop.Land.IAeccSettingsGradingSlopeUnit;
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
