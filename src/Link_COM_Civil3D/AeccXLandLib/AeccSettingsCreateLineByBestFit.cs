namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateLineByBestFit 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateLineByBestFit _i;
		internal AeccSettingsCreateLineByBestFit(object AeccSettingsCreateLineByBestFit_object) 
		{
			this._i = AeccSettingsCreateLineByBestFit_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateLineByBestFit;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic RegressionGraphOptionSettings => this._i.RegressionGraphOptionSettings;

		///<summary>
		///
		///</summary>
		public dynamic CurveTessellationOptionSettings => this._i.CurveTessellationOptionSettings;
	}
}
