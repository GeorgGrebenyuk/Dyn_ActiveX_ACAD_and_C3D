namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateProfileLayout 
	{
		public AeccXLandLib.IAeccSettingsCreateProfileLayout _i;
		internal AeccSettingsCreateProfileLayout(object AeccSettingsCreateProfileLayout_object) 
		{
			this._i = AeccSettingsCreateProfileLayout_object as AeccXLandLib.IAeccSettingsCreateProfileLayout;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

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
