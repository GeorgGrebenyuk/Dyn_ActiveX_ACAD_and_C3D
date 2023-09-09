namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsElevation 
	{
		public AeccXLandLib.IAeccSettingsElevation _i;
		internal AeccSettingsElevation(object AeccSettingsElevation_object) 
		{
			this._i = AeccSettingsElevation_object as AeccXLandLib.IAeccSettingsElevation;
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
		public dynamic Sign => this._i.Sign;
	}
}
