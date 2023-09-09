namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsVolume 
	{
		public AeccXLandLib.IAeccSettingsVolume _i;
		internal AeccSettingsVolume(object AeccSettingsVolume_object) 
		{
			this._i = AeccSettingsVolume_object as AeccXLandLib.IAeccSettingsVolume;
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
