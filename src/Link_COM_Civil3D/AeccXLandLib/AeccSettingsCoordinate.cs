namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCoordinate 
	{
		public AeccXLandLib.IAeccSettingsCoordinate _i;
		internal AeccSettingsCoordinate(object AeccSettingsCoordinate_object) 
		{
			this._i = AeccSettingsCoordinate_object as AeccXLandLib.IAeccSettingsCoordinate;
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
