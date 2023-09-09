namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCoordinateSystem 
	{
		public AeccXLandLib.IAeccSettingsCoordinateSystem _i;
		internal AeccSettingsCoordinateSystem(object AeccSettingsCoordinateSystem_object) 
		{
			this._i = AeccSettingsCoordinateSystem_object as AeccXLandLib.IAeccSettingsCoordinateSystem;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string CSCode => this._i.CSCode;

		///<summary>
		///
		///</summary>
		public void Set_CSCode(string pVal) 
		{
			this._i.CSCode = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public string Projection => this._i.Projection;

		///<summary>
		///
		///</summary>
		public string Datum => this._i.Datum;

		///<summary>
		///
		///</summary>
		public string Unit => this._i.Unit;
	}
}
