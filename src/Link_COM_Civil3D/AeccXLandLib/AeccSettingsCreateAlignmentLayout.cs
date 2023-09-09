namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateAlignmentLayout 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateAlignmentLayout _i;
		internal AeccSettingsCreateAlignmentLayout(object AeccSettingsCreateAlignmentLayout_object) 
		{
			this._i = AeccSettingsCreateAlignmentLayout_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateAlignmentLayout;
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
