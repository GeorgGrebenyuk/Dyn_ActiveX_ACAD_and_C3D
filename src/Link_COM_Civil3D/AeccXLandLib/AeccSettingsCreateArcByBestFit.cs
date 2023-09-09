namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateArcByBestFit 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateArcByBestFit _i;
		internal AeccSettingsCreateArcByBestFit(object AeccSettingsCreateArcByBestFit_object) 
		{
			this._i = AeccSettingsCreateArcByBestFit_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateArcByBestFit;
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
