namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsGridCoordinate 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsGridCoordinate _i;
		internal AeccSettingsGridCoordinate(object AeccSettingsGridCoordinate_object) 
		{
			this._i = AeccSettingsGridCoordinate_object as Autodesk.AECC.Interop.Land.IAeccSettingsGridCoordinate;
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
