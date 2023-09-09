namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsDistance 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsDistance _i;
		internal AeccSettingsDistance(object AeccSettingsDistance_object) 
		{
			this._i = AeccSettingsDistance_object as Autodesk.AECC.Interop.Land.IAeccSettingsDistance;
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
