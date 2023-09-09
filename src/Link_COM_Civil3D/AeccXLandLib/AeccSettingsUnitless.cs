namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsUnitless 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsUnitless _i;
		internal AeccSettingsUnitless(object AeccSettingsUnitless_object) 
		{
			this._i = AeccSettingsUnitless_object as Autodesk.AECC.Interop.Land.IAeccSettingsUnitless;
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
		public dynamic Sign => this._i.Sign;
	}
}
