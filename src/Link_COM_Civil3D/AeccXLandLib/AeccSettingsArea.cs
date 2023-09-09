namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsArea 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsArea _i;
		internal AeccSettingsArea(object AeccSettingsArea_object) 
		{
			this._i = AeccSettingsArea_object as Autodesk.AECC.Interop.Land.IAeccSettingsArea;
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
