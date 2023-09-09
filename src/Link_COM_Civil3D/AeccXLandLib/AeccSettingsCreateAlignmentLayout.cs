namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateAlignmentLayout 
	{
		public AeccXLandLib.IAeccSettingsCreateAlignmentLayout _i;
		internal AeccSettingsCreateAlignmentLayout(object AeccSettingsCreateAlignmentLayout_object) 
		{
			this._i = AeccSettingsCreateAlignmentLayout_object as AeccXLandLib.IAeccSettingsCreateAlignmentLayout;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CurveandSpiralOptionSettings => this._i.CurveandSpiralOptionSettings;

		///<summary>
		///
		///</summary>
		public dynamic CurveTessellationOptionSettings => this._i.CurveTessellationOptionSettings;

		///<summary>
		///
		///</summary>
		public dynamic RegressionGraphOptionSettings => this._i.RegressionGraphOptionSettings;
	}
}
