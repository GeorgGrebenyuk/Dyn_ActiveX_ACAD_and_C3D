namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateParabolaByBestFit 
	{
		public AeccXLandLib.IAeccSettingsCreateParabolaByBestFit _i;
		internal AeccSettingsCreateParabolaByBestFit(object AeccSettingsCreateParabolaByBestFit_object) 
		{
			this._i = AeccSettingsCreateParabolaByBestFit_object as AeccXLandLib.IAeccSettingsCreateParabolaByBestFit;
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
