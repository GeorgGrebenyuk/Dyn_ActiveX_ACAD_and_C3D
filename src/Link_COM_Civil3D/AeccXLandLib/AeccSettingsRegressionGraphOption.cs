namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsRegressionGraphOption 
	{
		public AeccXLandLib.IAeccSettingsRegressionGraphOption _i;
		internal AeccSettingsRegressionGraphOption(object AeccSettingsRegressionGraphOption_object) 
		{
			this._i = AeccSettingsRegressionGraphOption_object as AeccXLandLib.IAeccSettingsRegressionGraphOption;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SplineFitForGraph => this._i.SplineFitForGraph;
	}
}
