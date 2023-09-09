namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsRegressionGraphOption 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsRegressionGraphOption _i;
		internal AeccSettingsRegressionGraphOption(object AeccSettingsRegressionGraphOption_object) 
		{
			this._i = AeccSettingsRegressionGraphOption_object as Autodesk.AECC.Interop.Land.IAeccSettingsRegressionGraphOption;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SplineFitForGraph => this._i.SplineFitForGraph;
	}
}
