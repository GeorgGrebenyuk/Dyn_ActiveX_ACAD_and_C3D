namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateParabolaByBestFit 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateParabolaByBestFit _i;
		internal AeccSettingsCreateParabolaByBestFit(object AeccSettingsCreateParabolaByBestFit_object) 
		{
			this._i = AeccSettingsCreateParabolaByBestFit_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateParabolaByBestFit;
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
